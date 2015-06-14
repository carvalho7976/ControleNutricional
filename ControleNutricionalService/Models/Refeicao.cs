using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleNutricionalService.Models
{
    public class Refeicao
    {
        public Refeicao()
        {
            this.Alimentos = new List<Alimento>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Alimento> Alimentos { get; set; }

    }
}