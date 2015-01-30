using IBL.CPS.UI.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IBL.CPS.UI.srCasal
{
    public partial class ServiceCasalClient : IServiceClient<CasalDTO, CasalFTR> { }

    public partial class CasalFTR : IFTRClient { }

    [MetadataType(typeof(CasalModelMetadata))]
    public partial class CasalDTO :IDTOClient { }

    public partial class CasalContext : BaseContext<CasalDTO, CasalFTR, ServiceCasalClient> { }

    public class CasalModelMetadata {

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