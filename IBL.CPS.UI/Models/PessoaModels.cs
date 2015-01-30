using IBL.CPS.UI.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IBL.CPS.UI.srPessoa
{
    public partial class ServicePessoaClient : IServiceClient<PessoaDTO, PessoaFTR> { }

    public partial class PessoaFTR : IFTRClient { }

    [MetadataType(typeof(PessoaModelMetadata))]
    public partial class PessoaDTO :IDTOClient { }

    public partial class PessoaContext : BaseContext<PessoaDTO, PessoaFTR, ServicePessoaClient> { }

    public class PessoaModelMetadata {
        [Key]
        [Required]
        [Display(Name = "Código")]
        public int IDPESSOA { get; set; }

        [Display(Name = "Sexo")]
        public string SEXO { get; set; }

        [Required(ErrorMessage = "Campo Nome deve ser informado")]
        [StringLength(30, ErrorMessage = "Descrição não pode conter mais de 150 caracteres.")]
        [Display(Name = "Nome")]
        public string NOME { get; set; }

        [Required(ErrorMessage = "Campo data de nascimento deve ser informado")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DATANASC { get; set; }

        [Display(Name = "RG")]
        public string RG { get; set; }

        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Display(Name = "Telefone Fixo")]
        public string TELEFONE_FIXO { get; set; }

        [Display(Name = "Celular")]
        public string CELULAR { get; set; }

        [Required(ErrorMessage = "Campo E-mail deve ser informado")]
        [Display(Name = "E-mail")]
        public string E_MAIL { get; set; }
        
    }

}