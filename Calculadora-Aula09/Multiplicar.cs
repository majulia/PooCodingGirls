using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Aula09
{
    internal class Multiplicar : Calculadora
    {
        public override double Calcular()
        {
            return Resultado = Num1 * Num2;
        }
    }
}
