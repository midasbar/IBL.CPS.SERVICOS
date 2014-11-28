using IBL.CPS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IBL.CPS.SERVICOS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceCasal" in both code and config file together.
    [ServiceContract]
    public interface IServiceCasal
    {
        [OperationContract]
        List<CasalDTO> ObterLista(String desc);

        [OperationContract]
        void Incluir(CasalDTO dto);

        [OperationContract]
        void Gravar(CasalDTO dto);

        [OperationContract]
        void Excluir(Int32 id);

        [OperationContract]
        CasalDTO Obter(Int32 id);
    }
}
