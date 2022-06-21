using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio02
{
    public abstract class Calculadora
    {
        public double Resultado { get; set; }
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public abstract double Calcular();
    }
    
}
