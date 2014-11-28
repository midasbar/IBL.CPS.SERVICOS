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
        public List<FuncaoDTO> ObterLista(String desc)
        {
            return ControladorFuncao.ObterLista(desc);
        }
        public void Incluir(FuncaoDTO dto)
        {
            ControladorFuncao.Incluir(dto);
        }
        public void Gravar(FuncaoDTO dto)
        {
            ControladorFuncao.Gravar(dto);
        }
        public void Excluir(Int32 id)
        {
            ControladorFuncao.Excluir(id);
        }
        public FuncaoDTO Obter(Int32 id)
        {
            return ControladorFuncao.Obter(id);
        }
    }
}
