using IBL.CPS.UI.srFuncao;
using IBL.CPS.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBL.CPS.UI.Controllers
{
    public static class Lookups 
    {
        public static List<SelectListItem> GetListaFuncoes(FuncaoFTR filtro, String valorSelecionado, Boolean exibirOpcaoEmBranco = false){

            var listaTiposInvestimento = new List<SelectListItem>();
            if (exibirOpcaoEmBranco)
                listaTiposInvestimento.Add(new SelectListItem { Text = "-- selecione --", Value = "0" });

            using (var sc = new ServiceFuncaoClient())
            {
                var l = sc.ObterLista(filtro, TokenUtils.GetToken());
                foreach (FuncaoDTO ti in l)
                    listaTiposInvestimento.Add(new SelectListItem { Text = ti.DESCRICAO, Value = ti.ID.ToString(), Selected = valorSelecionado == ti.ID.ToString() });
            }
            return listaTiposInvestimento;



        }

    }
}
