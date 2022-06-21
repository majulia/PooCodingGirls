using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerAula05

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Media();
            //Voo();
            Calculadora();
        }

        static void Media()
        {
            Media media = new Media
            {
                matricula = 12345,
                nome = "Maria",
                notaP1 = 2,
                notaP2 = 8,
                notaTrabalho = 8,

            };

            media.calcularMedia();
            Console.ReadLine();
        }

        static void Voo()
        {
            Voo voo = new Voo
            {
                numeroPoltrona = 12,
            };

            Console.WriteLine(voo.OcuparPoltrona());
            Console.ReadLine();
        }

        static void Calculadora()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Calcular();

            Console.ReadLine();
        }

    }
}
