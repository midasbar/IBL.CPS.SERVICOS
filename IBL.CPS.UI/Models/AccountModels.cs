using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace IBL.CPS.UI.Models
{

    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha de Acesso Atual")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve possuir no mínimo {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova Senha de Acesso")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação")]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessage = "A Nova Senha de Acesso não foi confirmada corretamente.")]
        public string ConfirmPassword { get; set; }
    }

    public class LogInModel
    {
        [Required (ErrorMessage="Campo Obrigatório.")] 
        [Display(Name = "Usuário de Rede")]
        public string UserName { get; set; }

        [Required (ErrorMessage="Campo Obrigatório.")] 
        [DataType(DataType.Password)]
        [Display(Name = "Senha de Acesso")]
        public string Password { get; set; }

        [Display(Name = "Manter-me conectado")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "Usuário de Rede")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve possuir no mínimo {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha de Acesso")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "A Senha de Acesso não foi confirmada corretamente.")]
        public string ConfirmPassword { get; set; }
    }
}
