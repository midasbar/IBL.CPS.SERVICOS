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
    public class ServiceCasal : IServiceCasal
    {
        public List<CasalDTO> ObterLista(CasalFTR Filtro, String token)
        {
            return ControladorCasal.ObterLista(Filtro);
        }
        public void Incluir(CasalDTO dto, String token)
        {
            ControladorCasal.Incluir(dto);
        }
        public void Gravar(CasalDTO dto, String token)
        {
            ControladorCasal.Gravar(dto);
        }
        public void Excluir(Int32 id, String token)
        {
            ControladorCasal.Excluir(id);
        }
        public CasalDTO Obter(Int32 id, String token)
        {
            return ControladorCasal.Obter(id);
        }
    }
}
