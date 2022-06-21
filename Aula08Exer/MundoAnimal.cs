using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08Exer
{
    internal class MundoAnimal
    {
        public string nome { get; set; }
        public int patas { get; set; }
        public string cor { get; set; }
        public string ambiente { get; set; }
        public int velocidadeMedia { get; set; }

        public MundoAnimal()
        {
            Mamifero m = new Mamifero("Leão", "4", "Amarelo-claro", "Selva", "80");
            Peixe p = new Peixe("Peixe", "0", "Laranja", "Mar", "3");
            Inserir();
            Imprimir();
            Console.ReadLine();
        }

        public void Inserir()
        {
            Console.WriteLine("");
            Console.WriteLine("==== Insira um animal ====");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Patas: ");
            patas = int.Parse(Console.ReadLine());
            Console.Write("Cor: ");
            cor = Console.ReadLine();
            Console.Write("Ambiente: ");
            ambiente = Console.ReadLine();
            Console.Write("Velocidade: ");
            velocidadeMedia = int.Parse(Console.ReadLine());
        }


        public void Imprimir()
        {
            Console.WriteLine("==================");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Patas: " + patas);
            Console.WriteLine("Cor: " + cor);
            Console.WriteLine("Ambiente: " + ambiente);
            Console.WriteLine("Velocidade: " + velocidadeMedia);
            Console.WriteLine("==================");
        }
    }
}
