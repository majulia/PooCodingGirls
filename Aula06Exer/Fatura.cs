using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Exer
{
    internal class Fatura
    {
        public int Numero { get; set; }
        public int QuantidadeProduto { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

        
        public double CalculoFatura()
        {
            return QuantidadeProduto * Preco;
        }

        public void RelatoriFatura()
        {
            Console.WriteLine("========== Sua fatura ==========");
            Console.Write(" Descricao do Produto: " + Descricao);
            Console.Write(" | Quantidade : " + QuantidadeProduto);
            Console.WriteLine(" | Preço: " + Preco);
            Console.WriteLine($" Valor total:{CalculoFatura().ToString("F")}");
            Console.ReadLine();
        }

    }
}
