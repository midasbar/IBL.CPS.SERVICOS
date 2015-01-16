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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceParticipante" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceParticipante.svc or ServiceParticipante.svc.cs at the Solution Explorer and start debugging.
    public class ServiceParticipante : IServiceParticipante
    {
        public List<ParticipanteDTO> ObterLista(String desc, String token)
        {
            return ControladorParticipante.ObterLista();
        }
        public void Incluir(ParticipanteDTO dto, String token)
        {
            ControladorParticipante.Incluir(dto);
        }
        public void Gravar(ParticipanteDTO dto, String token)
        {
            ControladorParticipante.Gravar(dto);
        }
        public void Excluir(Int32 id, String token)
        {
            ControladorParticipante.Excluir(id);
        }
        public ParticipanteDTO Obter(Int32 id, String token)
        {
            return ControladorParticipante.Obter(id);
        }
    }
}
