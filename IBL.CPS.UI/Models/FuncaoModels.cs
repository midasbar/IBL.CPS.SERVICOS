using IBL.CPS.UI.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IBL.CPS.UI.srFuncao
{
    public partial class ServiceFuncaoClient : IServiceClient<FuncaoDTO, FuncaoFTR> { }

    public partial class FuncaoFTR : IFTRClient { }

    [MetadataType(typeof(FuncaoModelMetadata))]
    public partial class FuncaoDTO :IDTOClient { }

    public partial class FuncaoContext : BaseContext<FuncaoDTO, FuncaoFTR, ServiceFuncaoClient> { }

    public class FuncaoModelMetadata {
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