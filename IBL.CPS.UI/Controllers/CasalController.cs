using IBL.CPS.UI.Engine;
using IBL.CPS.UI.srCasal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBL.CPS.UI.Controllers
{
    [Authorize]
    public class CasalController : BaseController<CasalContext, CasalDTO, CasalFTR>
    {
        public override void CarregaPropriedadesDTO(CasalDTO model, FormCollection collection)
        {
            //model.DESCRICAO = collection["DESCRICAO"];
        }

        public override ActionResult CarregarLookups()
        {
            ViewBag.listaFuncoes = Lookups.GetListaFuncoes(null,"");
            return base.CarregarLookups();
        }

    }

}
