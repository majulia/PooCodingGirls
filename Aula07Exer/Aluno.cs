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


        public Aluno(string nome)
        {
            _nome = nome;
            _notas = new List<int>();
            _frequencia = 0;

            Console.WriteLine(_nome);
            Console.WriteLine(_frequencia);

        }

        public Aluno Cadastrar(string nome)
        {
            return new Aluno(nome);
        }

        public void AddNota(int nota)
        {
            _notas.Add(nota);

        }

        public void DefinirFrequencia(int frequencia)
        {
            _frequencia = frequencia;
        }
        

    }
}
