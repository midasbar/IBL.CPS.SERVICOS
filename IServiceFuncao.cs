using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IBL.CPS.Controlador;
using IBL.CPS.DTO;

namespace IBL.CPS.SERVICOS
{
    [ServiceContract]
    public interface IServiceFuncao
    {
        [OperationContract]
        List<FuncaoDTO> ObterLista(String desc);

        [OperationContract]
        void Incluir(FuncaoDTO dto);

        [OperationContract]
        void Gravar(FuncaoDTO dto);

        [OperationContract]
        void Excluir(Int32 id);

        [OperationContract]
        FuncaoDTO Obter(Int32 id);
    }

}
