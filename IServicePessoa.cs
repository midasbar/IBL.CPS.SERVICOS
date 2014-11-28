using IBL.CPS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IBL.CPS.SERVICOS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicePessoa" in both code and config file together.
    [ServiceContract]
    public interface IServicePessoa
    {
        [OperationContract]
        List<PessoaDTO> ObterLista(String desc);

        [OperationContract]
        void Incluir(PessoaDTO dto);

        [OperationContract]
        void Gravar(PessoaDTO dto);

        [OperationContract]
        void Excluir(Int32 id);

        [OperationContract]
        PessoaDTO Obter(Int32 id);
    }
}
