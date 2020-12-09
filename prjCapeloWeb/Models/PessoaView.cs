using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.Models
{
    public class PessoaView : BaseModel
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Senha { get; set; }
        [Display(Name = "Confirmação Senha")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [NotMapped]
        [Compare("Senha", ErrorMessage = "Campos não coincidem!")]
        public string ConfirmacaoSenha { get; set; }

    }
}
