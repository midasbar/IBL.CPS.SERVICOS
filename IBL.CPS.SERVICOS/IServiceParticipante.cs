using IBL.CPS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IBL.CPS.SERVICOS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceParticipante" in both code and config file together.
    [ServiceContract]
    public interface IServiceParticipante
    {
        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        List<ParticipanteDTO> ObterLista(String desc, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Incluir(ParticipanteDTO dto, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Gravar(ParticipanteDTO dto, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Excluir(Int32 id, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        ParticipanteDTO Obter(Int32 id, String token);
    }
}
