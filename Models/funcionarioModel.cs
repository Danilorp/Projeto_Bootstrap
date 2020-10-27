using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TemplateBootstrap.Models
{
    public class funcionarioModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "informe o Nome")]
        [Display(Name = "Nome:")]
        public string Nome { get; set; }

        public string Endereco { get; set; }

        [Display(Name = "E-mail:")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }
    }
}