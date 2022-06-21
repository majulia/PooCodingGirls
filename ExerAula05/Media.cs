using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerAula05
{
    internal class Media
    {
        public int matricula;
        public string nome;
        public double notaP1, notaP2, notaTrabalho, notaFinal, soma;

        public double media()
        {
            soma = (notaP1 + notaP2 + notaTrabalho);
            notaFinal = soma / 3;
            return notaFinal;
        }

        public void calcularMedia()
        {
            
            notaFinal = media();

            if (notaFinal >= 6)
            {
                Console.WriteLine("Aluno aprovado! || Nota:" + notaFinal);
            }
            else 
            {
                double notaFaltante = (30 - soma) / 3;
                Console.WriteLine("Aluno reprovado! || Nota:" + notaFinal);
                Console.WriteLine($"Nota mínima:{notaFaltante.ToString("F")}");

            }
        }

    }
}
