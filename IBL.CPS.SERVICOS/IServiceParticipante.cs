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
        [OperationContract]
        List<ParticipanteDTO> ObterLista(String desc);

        [OperationContract]
        void Incluir(ParticipanteDTO dto);

        [OperationContract]
        void Gravar(ParticipanteDTO dto);

        [OperationContract]
        void Excluir(Int32 id);

        [OperationContract]
        ParticipanteDTO Obter(Int32 id);
    }
}
