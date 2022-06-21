using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exer01
{
    internal class Trapezio : Formas
    {
        public double BaseMaior { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Area = ((BaseMaior * BaseMenor) * Altura) / 2;
        }
    }
}
