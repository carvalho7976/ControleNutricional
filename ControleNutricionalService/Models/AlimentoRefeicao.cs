﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleNutricionalService.Models
{
    public class AlimentoRefeicao
    {
        public int Id { get; set; }
        public virtual Alimento Alimento { get; set; }
        public virtual Refeicao Refeicao { get; set; }
        public double Quantidade { get; set; }

    }
}