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
        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        List<FuncaoDTO> ObterLista(FuncaoFTR Filtro , String token );
        
        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Incluir(FuncaoDTO dto, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Gravar(FuncaoDTO dto, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Excluir(Int32 id, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        FuncaoDTO Obter(Int32 id, String token);
    }

}
