using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.Models
{
    [Table("Disciplinas")]
    public class Disciplina : BaseModel
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MaxLength(3, ErrorMessage = "Máximo de 3 caracteres!")] //Só existe em campo string
        public string Sigla { get; set; }

        //public List<Professor> Professores { get; set; }

        //[Range(1,200,ErrorMessage = "Valores entre 1 e 200")] caso queira valores inteiros e etc
    }
}
