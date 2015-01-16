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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTipoGrupo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceTipoGrupo.svc or ServiceTipoGrupo.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTipoGrupo : IServiceTipoGrupo
    {
        public List<TipoGrupoDTO> ObterLista(TipoGrupoFTR Filtro, String token)
        {
            return ControladorTipoGrupo.ObterLista(Filtro);
        }

        public void Incluir(TipoGrupoDTO dto, String token)
        {
            ControladorTipoGrupo.Incluir(dto);
        }

        public void Gravar(TipoGrupoDTO dto, String token)
        {
            ControladorTipoGrupo.Gravar(dto);
        }

        public void Excluir(Int32 id, String token)
        {
            ControladorTipoGrupo.Excluir(id);
        }
        public TipoGrupoDTO Obter(Int32 id, String token)
        {
            return ControladorTipoGrupo.Obter(id);
        }
    }
}
