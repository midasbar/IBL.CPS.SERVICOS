using IBL.CPS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IBL.CPS.SERVICOS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceTipoGrupo" in both code and config file together.
    [ServiceContract]
    public interface IServiceTipoGrupo
    {
        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        List<TipoGrupoDTO> ObterLista(TipoGrupoFTR Filtro, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Incluir(TipoGrupoDTO dto, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Gravar(TipoGrupoDTO dto, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        void Excluir(Int32 id, String token);

        [TokenInspector]
        [FaultContract(typeof(TokenFaultContract))]
        [OperationContract]
        TipoGrupoDTO Obter(Int32 id, String token);

    }
}
