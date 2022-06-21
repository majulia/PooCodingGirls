using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08Exer
{
    internal class Mamifero : Animal
    {
        public Mamifero(string _nome, string _patas, string _cor, string _ambiente, string _velocidadeMedia) : base(_nome, _patas, _cor, _ambiente, _velocidadeMedia)
        {
         
            Console.WriteLine("==== Mamifero ====");
            Console.WriteLine("Nome: " + _nome);
            Console.WriteLine("Patas: " + _patas);
            Console.WriteLine("Cor: " + _cor);
            Console.WriteLine("Ambiente: " + _ambiente);
            Console.WriteLine("Velocidade: " + _velocidadeMedia);

        }

    }
}
