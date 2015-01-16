using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBL.CPS.UI.srFuncao ;
using IBL.CPS.UTILS;

namespace IBL.CPS.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        { 
            
           using (var sc = new srFuncao.ServiceFuncaoClient( ) )
            {

                var dto = sc.Obter(1, TokenUtils.GetToken());

                ViewBag.Message = dto.DESCRICAO; //"Your app description page.";

            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
