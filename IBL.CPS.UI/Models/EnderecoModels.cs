using IBL.CPS.UI.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IBL.CPS.UI.Models
{

    [MetadataType(typeof(EnderecoModelMetadata))]
    public partial class EnderecoDTO
    {

        public string UF { get; set; }

        public string CIDADE { get; set; }

        public string BAIRRO { get; set; }

        public string ENDERECO { get; set; }

        public string NUMERO { get; set; }

        public string COMPLEMENTO { get; set; }

        public string CEP { get; set; }
    }

    public class EnderecoModelMetadata
    {
        [Required(ErrorMessage = "Campo UF deve ser informado")]
        [Display(Name = "UF")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Campo Cidade deve ser informado")]
        [Display(Name = "Cidade")]
        public string CIDADE { get; set; }

        [Required(ErrorMessage = "Campo Bairro deve ser informado")]
        [Display(Name = "Bairro")]
        public string BAIRRO { get; set; }

        [Required(ErrorMessage = "Campo Endereço deve ser informado")]
        [Display(Name = "Endereço")]
        public DateTime ENDERECO { get; set; }

        [Required(ErrorMessage = "Campo Numero deve ser informado")]
        [Display(Name = "Numero")]
        public string NUMERO { get; set; }

        [Required(ErrorMessage = "Campo Complemento deve ser informado")]
        [Display(Name = "Complemento")]
        public string COMPLEMENTO { get; set; }

        [Required(ErrorMessage = "Campo CEP deve ser informado")]
        [Display(Name = "CEP")]
        public string CEP { get; set; }
    }

}