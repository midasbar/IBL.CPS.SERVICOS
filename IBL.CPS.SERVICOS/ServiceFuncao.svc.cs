using IBL.CPS.DTO;
using IBL.CPS.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IBL.CPS.SERVICOS
{
    public class ServiceFuncao : IServiceFuncao
    {
        public List<FuncaoDTO> ObterLista(FuncaoFTR Filtro, String token)
        {
            return ControladorFuncao.ObterLista(Filtro);
        }
        public void Incluir(FuncaoDTO dto, String token)
        {
            ControladorFuncao.Incluir(dto);
        }
        public void Gravar(FuncaoDTO dto, String token)
        {
            ControladorFuncao.Gravar(dto);
        }
        public void Excluir(Int32 id, String token)
        {
            ControladorFuncao.Excluir(id);
        }
        public FuncaoDTO Obter(Int32 id, String token)
        {
            return ControladorFuncao.Obter(id);
        }
    }
}
