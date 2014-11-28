using IBL.CPS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IBL.CPS.SERVICOS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IServiceTipoGrupo
    {
        [OperationContract]
        List<TipoGrupoDTO> ObterLista(String desc);

        [OperationContract]
        void Incluir(TipoGrupoDTO dto);

        [OperationContract]
        void Gravar(TipoGrupoDTO dto);

        [OperationContract]
        void Excluir(Int32 id);

        [OperationContract]
        TipoGrupoDTO Obter(Int32 id);
    }
}
