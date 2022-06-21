using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exer01
{
    internal class Circulo : Formas
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Area = (Raio * Raio) * Math.PI;
        }

    }
}
