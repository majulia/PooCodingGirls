using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Aula09
{
    internal class Raiz : Calculadora
    {
        public override double Calcular()
        {
            return Resultado = Math.Sqrt(Num1);
        }
    }
}
