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
        [OperationContract]
        List<GrupoDTO> ObterLista(String desc);

        [OperationContract]
        void Incluir(GrupoDTO dto);

        [OperationContract]
        void Gravar(GrupoDTO dto);

        [OperationContract]
        void Excluir(Int32 id);

        [OperationContract]
        GrupoDTO Obter(Int32 id);
    }
}
