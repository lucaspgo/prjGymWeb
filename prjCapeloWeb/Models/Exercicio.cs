using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.Models
{
    public class Exercicio : BaseModel
    {
        public Exercicio()
        {
            GrupoMuscular = new GrupoMuscular();
        }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public int NumeroRepeticoes { get; set; }
        public double Peso { get; set; }
        public int Series { get; set; }
        public int TempoDescanso { get; set; }

        [ForeignKey("GrupoMuscularId ")]
        public GrupoMuscular GrupoMuscular{ get; set; }
        public int GrupoMuscularId { get; set; }
    }
}
