using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Exer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalcularSalario();
            //Fatura();
            //Sorteio();
            //ManipulandoStrings();
        }


        static void CalcularSalario()
        {
            GerenciarSalarios gerenciarSalarios = new GerenciarSalarios
            {
                Nome = "Maria",
                Cargo = "Funcionaria",
                salario = 1.200,
            };

            gerenciarSalarios.msg();
            Console.ReadLine();
        }

        static void Fatura()
        {
            Fatura fatura = new Fatura
            {
                Descricao = "PC",
                QuantidadeProduto = 2,
                Preco = 200,
            };

            fatura.RelatoriFatura();
            
        }

        static void Sorteio()
        {
            Sorteio sorteio = new Sorteio();
            sorteio.Sortear();
            Console.ReadLine();
        }

        static void ManipulandoStrings()
        {
            ManipulandoStrings manipular = new ManipulandoStrings
            {
                nome = "Angela Santos",
            };
            
            manipular.SepararAbreviar();
            Console.ReadLine();
        }

    }
}
