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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTipoGrupo : IServiceTipoGrupo
    {
        public List<TipoGrupoDTO> ObterLista(String desc)
        {
           return ControladorTipoGrupo.ObterLista(desc);
        }

        public void Incluir(TipoGrupoDTO dto)
        {
            ControladorTipoGrupo.Incluir(dto);
        }

        public void Gravar(TipoGrupoDTO dto)
        {
            ControladorTipoGrupo.Gravar(dto);
        }

        public void Excluir(Int32 id)
        {
            ControladorTipoGrupo.Excluir(id);
        }
        public TipoGrupoDTO Obter(Int32 id)
        {
            return ControladorTipoGrupo.Obter(id);
        }
    }
}
