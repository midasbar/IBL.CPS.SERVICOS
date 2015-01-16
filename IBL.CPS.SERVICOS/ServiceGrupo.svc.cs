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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceGrupo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceGrupo.svc or ServiceGrupo.svc.cs at the Solution Explorer and start debugging.
    public class ServiceGrupo : IServiceGrupo
    {
        public List<GrupoDTO> ObterLista(String desc, String token)
        {
            return ControladorGrupo.ObterLista();
        }
        public void Incluir(GrupoDTO dto, String token)
        {
            ControladorGrupo.Incluir(dto);
        }
        public void Gravar(GrupoDTO dto, String token)
        {
            ControladorGrupo.Gravar(dto);
        }
        public void Excluir(Int32 id, String token)
        {
            ControladorGrupo.Excluir(id);
        }
        public GrupoDTO Obter(Int32 id, String token)
        {
            return ControladorGrupo.Obter(id);
        }
    }
}
