using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08Exer
{
    internal class Peixe : Animal
    {

        public Peixe(string _nome, string _patas, string _cor, string _ambiente, string _velocidadeMedia) : base(_nome, _patas, _cor, _ambiente, _velocidadeMedia)
        {
            _nome = "Peixe palhaço";
            _patas = "0";
            _cor = "Laranja com listras pretas e brancas ";
            _ambiente = "Mar";
            _velocidadeMedia = "3";

            Console.WriteLine("==== Peixe ====");
            Console.WriteLine("Nome: " + _nome);
            Console.WriteLine("Patas: " + _patas);
            Console.WriteLine("Cor: " + _cor);
            Console.WriteLine("Ambiente: " + _ambiente);
            Console.WriteLine("Velocidade: " + _velocidadeMedia);
        }

    }
}
