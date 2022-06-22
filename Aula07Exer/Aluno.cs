using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Exer
{
    internal class Aluno
    {
        private string _nome;
        private List<int> _notas;
        private int _frequencia;


        public Aluno()
        {
            _notas = new List<int>();

            Console.WriteLine("==== Cadastro de Aluno =====");

        }

        public void Cadastrar(string nome)
        {
            _nome = nome;
            Console.WriteLine("Nome: " + _nome);
        }

        public void AddNota(int nota)
        {
            _notas.Add(nota);

            foreach (var n in _notas)
            {
                Console.WriteLine("Nota: " + n);
            }

        }

        public void DefinirFrequencia(int frequencia)
        {
            _frequencia = frequencia;
            Console.WriteLine("Frequencia: " + _frequencia);

        }


    }
}
