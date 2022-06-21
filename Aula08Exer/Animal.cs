using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08Exer
{
    internal class Animal
    {
        public string nome { get; set; }
        public string patas { get; set; }
        public string cor { get; set; }
        public string ambiente { get; set; }
        public string velocidadeMedia { get; set; }

        public Animal(string _nome, string _patas, string _cor, string _ambiente, string _velocidadeMedia)
        {
            _nome = nome;
            _patas = patas;
            _cor = cor;
            _ambiente = ambiente;
            _velocidadeMedia = velocidadeMedia;
        }
       
    }
}
