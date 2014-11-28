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
        public List<CasalDTO> ObterLista(String desc)
        {
            return ControladorCasal.ObterLista();
        }
        public void Incluir(CasalDTO dto)
        {
            ControladorCasal.Incluir(dto);
        }
        public void Gravar(CasalDTO dto)
        {
            ControladorCasal.Gravar(dto);
        }
        public void Excluir(Int32 id)
        {
            ControladorCasal.Excluir(id);
        }
        public CasalDTO Obter(Int32 id)
        {
            return ControladorCasal.Obter(id);
        }
    }
}
