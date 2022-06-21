using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Exer
{
    internal class Sorteio
    {
        public int numero { get; set; }
        int numeroRandom;

        private int Random()
        {
            Random randNum = new Random();
            return randNum.Next(1000);
        }

        public void Sortear()
        {
            Console.WriteLine("Entre com um número:");
            numero = Convert.ToInt32(Console.ReadLine());

            numeroRandom = Random();

            if (numero == numeroRandom)
            {
                Console.WriteLine("Você ganhou essa rodada!");
                Console.WriteLine("Numero sorteado: " + numeroRandom);
            }
            else if (numero < numeroRandom)
            {
                Console.WriteLine("O número que você digitou é menor!");
                Console.WriteLine("Numero sorteado: " + numeroRandom);
                Rodadas();
            }
            else if (numero > numeroRandom)
            {
                Console.WriteLine("O número que você digitou é maior!");
                Console.WriteLine("Numero sorteado: " + numeroRandom);

                Rodadas();
            }
        }

        private int Contador()
        {
            int contador = 1;
            return contador += 1;
        }

        private void Rodadas()
        {
            string escolha = "S";
            Console.WriteLine("Jogar novamente? (S/N)");
            escolha = Console.ReadLine();
            switch (escolha)
            {
                case "S":
                    Console.Clear();
                    Sortear();
                    Contador();
                    break;
                case "N":
                    Console.WriteLine("Número de rodadas:" + Contador());
                    break;
            }
        }

    }
}
