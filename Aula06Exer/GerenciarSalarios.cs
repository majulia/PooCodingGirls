using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Exer
{
    internal class GerenciarSalarios
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double salario;

        public double CalcularSalario()
        {

            if (salario == 0 || salario <= 400.00)
            {
                salario = salario + (0.15 * salario);
            }
            else if (salario == 400.01 || salario <= 800.00)
            {
                salario = salario + (0.12 * salario);
            }
            else if (salario == 800.01 || salario <= 1200.00)
            {
                salario = salario + (0.10 * salario);
            }
            else if (salario == 1200.01 || salario <= 2000.00)
            {
                salario = salario + (0.07 * salario);
            }
            else if (salario > 2000.00)
            {
                salario = salario + (0.07 * salario);
            }

            return salario;
        }

        public void msg()
        {

            Console.WriteLine("Seu novo salário:" + CalcularSalario());

        }


    }


}
