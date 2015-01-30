using IBL.CPS.Controlador;
using IBL.CPS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IBL.CPS.SERVICOS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicePessoa" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicePessoa.svc or ServicePessoa.svc.cs at the Solution Explorer and start debugging.
    public class ServicePessoa : IServicePessoa
    {
        public List<PessoaDTO> ObterLista(PessoaFTR Filtro, String token)
        {
            return ControladorPessoa.ObterLista();
        }
        public void Incluir(PessoaDTO dto, String token)
        {
            ControladorPessoa.Incluir(dto);
        }
        public void Gravar(PessoaDTO dto, String token)
        {
            ControladorPessoa.Gravar(dto);
        }
        public void Excluir(Int32 id, String token)
        {
            ControladorPessoa.Excluir(id);
        }
        public PessoaDTO Obter(Int32 id, String token)
        {
            return ControladorPessoa.Obter(id);
        }
    }
}
