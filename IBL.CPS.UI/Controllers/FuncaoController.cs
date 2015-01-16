using IBL.CPS.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBL.CPS.UI.Engine;
using IBL.CPS.UI.srFuncao;


namespace IBL.CPS.UI.Controllers
{
    // public class FuncaoController : Controller
    [Authorize]
    public class FuncaoController : BaseController<FuncaoContext, FuncaoDTO, FuncaoFTR>
    {
        
        public override void CarregaPropriedadesDTO(FuncaoDTO model, FormCollection collection)
        {
            model.DESCRICAO = collection["DESCRICAO"];
        }

    }
}
