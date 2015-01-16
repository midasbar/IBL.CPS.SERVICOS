using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IBL.CPS.UI.Models
{
    [MetadataType(typeof(TipoGrupoModelMetadata))]
    public partial class TipoGrupoDTO
    {
    }

    public class TipoGrupoModelMetadata
    {
        [Key]
        [Required]
        [Display(Name = "Código")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Descricao deve ser informado")]
        [Display(Name = "Descrição")]
        [StringLength(150, ErrorMessage = "Descrição não pode conter mais de 150 caracteres.")]
        public string DESCRICAO { get; set; }
    }

}