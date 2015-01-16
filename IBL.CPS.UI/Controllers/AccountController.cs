using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
// using Arcelor.CtrlCultura.UI.srSCAD016;
using IBL.CPS.UI.Models;

namespace IBL.CPS.UI.Controllers
{
   
    public class AccountController : Controller
    {

        //
        // GET: /Account/LogIn

        public ActionResult LogIn()
        {
            return View();
        }


        //
        // POST: /Account/LogIn

        [HttpPost]
        public ActionResult LogIn(LogInModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                //if (Membership.ValidateUser(model.UserName, model.Password))
                if (ValidateUser(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {

                        return Redirect(returnUrl);
                    }
                    else
                    {
                        //Pagina padrao do sistema.
						return RedirectToAction("Index", "Agenda");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Usuário não ativado ou login e senha fornecidos estão incorretos.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/LogOff

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Agenda");
        }

        //
        // GET: /Account/Register

        public ActionResult Register()
        {
            if (!Request.IsAuthenticated)
                return RedirectToAction("LogIn", "Account");

            return View();
        }

        #region "Integração com Controle de Usuario"

        private Boolean CreateUser(String UserName, String Password, String Email, String Name, out String erros)
        {
            erros = String.Empty;

            /*
             * try
            {

                var uc = new UsuarioController();
                var dto = new UsuarioDTO();
                dto.Login = UserName;
                dto.Senha = Utils.CriptografarSenha(Password);
                dto.Email = Email;
                dto.Ativo = true;
                dto.NomePessoa = Name;
                uc.context.Incluir(dto);

                return true;
            }
            catch (Exception ex)
            {
                erros = ex.Message;
            }
             
            return false;
            */
            return true;
        }

        private Boolean ChangePassword(String OldPassword, String NewPassword)
        {
            /*
            var uc = new UsuarioController();
            var ftr = new UsuarioFTR();
            ftr.Login = User.Identity.Name;
            var l = uc.context.ObterLista(ftr);

            if (l.Count > 0)
            {
                var info = l[0];
                info.Senha = Utils.CriptografarSenha(NewPassword);
                uc.context.Gravar(info);
            }

            */
            return true;
        }

        private Boolean ValidateUser(String UserName, String Password)
        {
           /*
            var uc = new UsuarioController();
            var ftr = new UsuarioFTR();
            ftr.Login = UserName;
            ftr.ApenasUsuariosAtivos = true;
            var l = uc.context.ObterLista(ftr);

            if (l.Count > 0)
            {
                var info = l[0];

                if (info.Senha == Utils.CriptografarSenha(Password))
                    return true;
            }

            

            return false;
            */

            return ((UserName == "andre") && (Password == "123456"));

        }

        #endregion

        //
        // POST: /Account/Register

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                //MembershipCreateStatus createStatus;
                //Membership.CreateUser(model.UserName, model.Password, model.Email, null, null, true, null, out createStatus);
                String erros = String.Empty;

                if (CreateUser(model.UserName, model.Password, model.Email, model.Name, out erros))
                {
                    return RedirectToAction("RegisterSuccess");
                }
                else
                {
                    ModelState.AddModelError("", erros);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ChangePassword

        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }


        //
        // POST: /Account/ChangePassword

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {

                // ChangePassword will throw an exception rather
                // than return false in certain failure scenarios.
                bool changePasswordSucceeded;
                try
                {
                    changePasswordSucceeded = ChangePassword(model.OldPassword, model.NewPassword);
                }
                catch (Exception)
                {
                    changePasswordSucceeded = false;
                }

                if (changePasswordSucceeded)
                {
                    return RedirectToAction("ChangePasswordSuccess");
                }
                else
                {
                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ChangePasswordSuccess

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }

        public ActionResult RegisterSuccess()
        {
            return View();
        }

        #region Status Codes
        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion
    }
}
