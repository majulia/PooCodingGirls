using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Aula09
{
    internal class Potencia : Calculadora
    {
        public override double Calcular()
        {
            return Resultado = Math.Pow(Num1, Num2);
        }

    }
}
