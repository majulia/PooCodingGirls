using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exer01
{
    internal class Menu
    {
        public Menu()
        {
            Quadrado q = new Quadrado();
            Circulo c = new Circulo();
            Triangulo t = new Triangulo();
            Losango l = new Losango();
            Retangulo r = new Retangulo();
            Trapezio tr = new Trapezio();

            Console.WriteLine("Escolha uma forma:");
            Console.WriteLine("1 - Triangulo");
            Console.WriteLine("2 - Quadrado");
            Console.WriteLine("3 - Losango");
            Console.WriteLine("4 - Retangulo");
            Console.WriteLine("5 - Trapezio");
            Console.WriteLine("6 - Circulo");
            Console.Write("> ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {

                case 1:
                    Console.WriteLine("Base: ");
                    t.Base = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Altura: ");
                    t.Altura = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Area: " + t.CalcularArea());
                    Console.ReadLine();
                    break;

                case 2:
                    Console.Write("Lado: ");
                    q.Lado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area: " + q.CalcularArea());
                    Console.ReadLine();

                    break;

                case 3:
                    Console.WriteLine("Diagonal Maior: ");
                    l.DiagonalMaior = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Diagonal Menor: ");
                    l.DiagonalMenor = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Area: " + l.CalcularArea());
                    Console.ReadLine();

                    break;

                case 4:
                    Console.WriteLine("Base: ");
                    r.Base = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Altura: ");
                    r.Altura = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Area: " + r.CalcularArea());
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Base Maior:");
                    tr.BaseMaior = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Base Menor:");
                    tr.BaseMenor = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area: " + tr.CalcularArea());
                    Console.ReadLine();

                    break;

                case 6:
                    Console.Write("Raio: ");
                    c.Raio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area: " + c.CalcularArea());
                    Console.ReadLine();

                    break;

                default:
                    Console.WriteLine("Opção Inválida!");
                    Console.WriteLine("Escolha de 1 a 6");
                    break;
            }


        }
    }
}
