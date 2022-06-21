using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exer01
{
    internal class Triangulo : Formas
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double CalcularArea()
        {
            return Area = (Base * Altura) / 2;
        }
    }
}
