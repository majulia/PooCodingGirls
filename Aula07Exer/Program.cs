using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Exer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            int nota;
            string nome;
            int frequencia;

            Console.WriteLine("Nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Entre com a nota: ");
            nota = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Frequencia em % : ");
            frequencia = Convert.ToInt32(Console.ReadLine());
            
            a.AddNota(nota);
            a.Cadastrar(nome);
            a.DefinirFrequencia(frequencia);
            Console.ReadLine();
        }

    }
}
