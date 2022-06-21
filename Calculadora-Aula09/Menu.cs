using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Aula09
{
    internal class Menu
    {
        public Menu()
        {
            Soma s = new Soma();
            Dividir d = new Dividir();
            Multiplicar m = new Multiplicar();
            Subtrair sub = new Subtrair();
            Raiz r = new Raiz();
            Potencia p = new Potencia();


            Console.WriteLine("Escolha uma forma:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Dividir");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Subtrair");
            Console.WriteLine("5 - Raiz Quadrada");
            Console.WriteLine("6 - Potencia");
            Console.Write("> ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {

                case 1:
                    Console.WriteLine("============ Soma ============");
                    Console.WriteLine("Numero 1: ");
                    s.Num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Numero 2: ");
                    s.Num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Resultado: " + s.Calcular());
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("============ Divisão ============");
                    Console.WriteLine("Numero 1: ");
                    d.Num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Numero 2: ");
                    d.Num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Resultado: " + d.Calcular());
                    Console.ReadLine();

                    break;

                case 3:
                    Console.WriteLine("============ Multiplicação ============");
                    Console.WriteLine("Numero 1: ");
                    m.Num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Numero 2: ");
                    m.Num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Resultado: " + m.Calcular());
                    Console.ReadLine();

                    break;

                case 4:
                    Console.WriteLine("============ Subtração ============");
                    Console.WriteLine("Numero 1: ");
                    sub.Num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Numero 2: ");
                    sub.Num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Resultado: " + sub.Calcular());
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("============ Raiz Quadrada ============");
                    Console.WriteLine("Entre com o número que deseja calcular a raiz: ");
                    r.Num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultado: " + r.Calcular());
                    Console.ReadLine();

                    break;

                case 6:
                    Console.WriteLine("============ Potência ============");
                    Console.WriteLine("Entre com o número que deseja calcular: ");
                    p.Num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Entre com o número da potência: ");
                    p.Num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultado: " + p.Calcular());
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
