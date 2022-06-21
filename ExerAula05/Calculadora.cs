using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerAula05
{
    internal class Calculadora
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }


        private double adicao()
        {
            return Num1 + Num2;
        }
        private double multiplicacao()
        {
            return Num1 * Num2;
        }
        private double subtracao()
        {
            return Num1 + Num2;
        }
        private double divisao()
        {
            return Num1 / Num2;
        }

        public void Calcular()
        {
            Console.WriteLine("Numero 1:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero 2:");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Soma: " + adicao());
            Console.WriteLine("Subtracao: " + subtracao());
            Console.WriteLine("Multiplicação: " + multiplicacao());
            Console.WriteLine("Divisão: " + divisao());
            Zerar();
        }

        private void Zerar()
        {
            bool encerrar = true;
            string escolha;

            Console.WriteLine("Calcular novamente? (S/N)");
            escolha = Console.ReadLine();


            if (escolha == "S")
            {
                Console.Clear();
                Calcular();
            }
            else
            {
                encerrar = false;
                Console.WriteLine("Pressione Enter para fechar...");
            }

        }

    }
}
