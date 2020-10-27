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

        [Required(ErrorMessage = "Informe o Nome")]
        [Display(Name = "Nome:")]
        public string Nome { get; set; }

        [Display(Name = "Endereço:")]
        public string Endereco { get; set; }

        [Display(Name = "E-mail:")]
        [EmailAddress(ErrorMessage ="E-mail Inválido")]
        public string Email { get; set; }       
    }
}