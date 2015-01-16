using IBL.CPS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IBL.CPS.SERVICOS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceGrupo" in both code and config file together.
    [ServiceContract]
    public interface IServiceGrupo
    {
        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        List<GrupoDTO> ObterLista(String desc, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Incluir(GrupoDTO dto, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Gravar(GrupoDTO dto, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Excluir(Int32 id, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        GrupoDTO Obter(Int32 id, String token);
    }
}
