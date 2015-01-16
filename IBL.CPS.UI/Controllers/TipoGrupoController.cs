using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBL.CPS.UTILS;

namespace IBL.CPS.UI.Controllers
{
    public class TipoGrupoController : Controller
    {
        //
        // GET: /TipoGrupo/

        public ActionResult Index()
        {
            var l = new List<srTipoGrupo.TipoGrupoDTO>();

            using (var sc = new srTipoGrupo.ServiceTipoGrupoClient())
            {
                var lista = new srTipoGrupo.TipoGrupoFTR();

                l = sc.ObterLista(lista, TokenUtils.GetToken()).ToList();

            }
            return View(l);
        }
        //
        // GET: /TipoGrupo/Details/5

        public ActionResult Details(int id)
        {
            srTipoGrupo.TipoGrupoDTO dto = null;

            using (var sc = new srTipoGrupo.ServiceTipoGrupoClient())
            {

                dto = sc.Obter(id, TokenUtils.GetToken());

            }

            return View(dto);
        }

        //
        // GET: /TipoGrupo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoGrupo/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var dto = new srTipoGrupo.TipoGrupoDTO();

                using (var sc = new srTipoGrupo.ServiceTipoGrupoClient())
                {
                    dto.DESCRICAO = collection["DESCRICAO"];
                    sc.Incluir(dto, TokenUtils.GetToken());
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TipoGrupo/Edit/5

        public ActionResult Edit(int id)
        {
            //var dto = new srTipoGrupo.TipoGrupoDTO();
            srTipoGrupo.TipoGrupoDTO dto = null;

            using (var sc = new srTipoGrupo.ServiceTipoGrupoClient())
            {

                dto = sc.Obter(id, TokenUtils.GetToken());

            }

            return View(dto);
        }

        //
        // POST: /TipoGrupo/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                srTipoGrupo.TipoGrupoDTO dto = null;

                using (var sc = new srTipoGrupo.ServiceTipoGrupoClient())
                {
                    dto = sc.Obter(id, TokenUtils.GetToken());
                    dto.DESCRICAO = collection["DESCRICAO"];
                    sc.Gravar(dto, TokenUtils.GetToken());
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TipoGrupo/Delete/5

        public ActionResult Delete(int id)
        {
            srTipoGrupo.TipoGrupoDTO dto = null;

            using (var sc = new srTipoGrupo.ServiceTipoGrupoClient())
            {

                dto = sc.Obter(id, TokenUtils.GetToken());

            }

            return View(dto);
        }

        //
        // POST: /TipoGrupo/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                using (var sc = new srTipoGrupo.ServiceTipoGrupoClient())
                {
                    sc.Excluir(id, TokenUtils.GetToken());
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
