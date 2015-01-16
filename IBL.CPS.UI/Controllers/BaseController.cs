using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBL.CPS.UI.Engine
{
    public abstract class BaseController<T, D, F> : Controller
        where T : IBaseContext<D, F>, new()
        where D : IDTOClient
        where F : IFTRClient
    {

        public T context;

        public BaseController()
        {
            context = new T();
        }

        //Pattern : http://msdn.microsoft.com/pt-br/library/vstudio/b1yfkh5e(v=vs.100).aspx
        private bool disposed = false;
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //Liberar recursos gerenciados
                    context = default(T);
                }
                //Liberar recursos não gerenciados

                disposed = true;
            }
            base.Dispose(disposing);
        }


        public D ObterDTO(Int32 Id)
        {
            return context.Obter(Id);
        }

        public List<D> ObterLista(F filter)
        {
            return context.ObterLista(filter);
        }

        public virtual ActionResult CarregarLookups()
        {
            return null;
        }

        public virtual void CarregaPropriedadesDTO(D model, FormCollection collection)
        {

        }

        public ActionResult Index()
        {

            var results = context.ObterLista(default(F));

            return View(results);
        }


        public ActionResult Details(int id)
        {
            var model = ObterDTO(id);

            return View(model);
        }


        public ActionResult Create()
        {
            CarregarLookups();
            return View();
        }


        [HttpPost]
        public ActionResult Create(D model, FormCollection collection)
        {
            CarregaPropriedadesDTO(model, collection);
            context.Incluir(model);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {

            var model = ObterDTO(id);
            CarregarLookups();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(D model, FormCollection collection)
        {
            model = ObterDTO(model.ID);
            CarregaPropriedadesDTO(model, collection);
            context.Gravar(model);


            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var model = ObterDTO(id);
            return View(model);
        }


        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            context.Excluir(id);
            return RedirectToAction("Index");
        }

        //protected override void OnException(ExceptionContext exceptionContext)
        //{
        //    if (Request.IsAjaxRequest())
        //    {

        //        exceptionContext.Result = Json(new { ErrorMessage = exceptionContext.Exception, });

        //        exceptionContext.ExceptionHandled = true;
        //        exceptionContext.HttpContext.Response.Clear();
        //        exceptionContext.HttpContext.Response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;
        //        exceptionContext.HttpContext.Response.TrySkipIisCustomErrors = true; 
        //    }
        //}


    }
}
