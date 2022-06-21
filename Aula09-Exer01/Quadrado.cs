using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exer01
{
    internal class Quadrado : Formas
    {
        public double Lado { get; set; }
        public override double CalcularArea()
        {
            return Area = Math.Pow(Lado, 2);
        }
    }
}
