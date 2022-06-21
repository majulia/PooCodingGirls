using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Exer
{
    internal class ManipulandoStrings
    {
        public string nome { get; set; }
        public string primeiro = " ";
        public string meio = " ";
        public string ultimo = " ";

        public void SepararAbreviar()
        {
            string[] nomes = nome.Split(' ');

            for (int i = 0; i < nomes.Length; i++)
            {
                if (!nomes[i].ToLower().Equals("de") && !nomes[i].ToLower().Equals("da") && !nomes[i].ToLower().Equals("do") && !nomes[i].ToLower().Equals("das") && !nomes[i].ToLower().Equals("dos"))
                {
                    meio += nomes[i].Substring(0, 1);
                    meio += ". "; 
                }
            }

            nome = primeiro + meio + ultimo;
            Console.WriteLine(nome);
        }

    }
}
