﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exer01
{
    internal class Losango : Formas
    {
        public double DiagonalMaior { get; set; }
        public double DiagonalMenor { get; set; }
        public override double CalcularArea()
        {
            return Area = (DiagonalMaior * DiagonalMenor) / 2;
        }
    }
}
