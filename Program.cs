using System;
using System.IO;
using System.Collections.Generic;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            List<int> idades = new List<int>();
            List<double> notas = new List<double>();
            double soma = 0.0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o nome do {i+1}º aluno: ");
                string? entrada1 = Console.ReadLine();
                Console.WriteLine($"Digite a idade do {i+1}º aluno: ");
                string? entrada2 = Console.ReadLine();
                Console.WriteLine($"Digite a nota do {i+1}º aluno: ");
                string? entrada3 = Console.ReadLine();
                int idade;
                double nota;
                bool verifica2 = int.TryParse(entrada2, out idade);
                bool verifica3 = double.TryParse(entrada3, out nota);
                if (entrada1 != null) {
                    string nome = entrada1.ToString();
                    nomes.Add(nome);
                } else {
                    Console.WriteLine($"O nome do aluno não pode ser nulo.");
                }
                if (verifica2 == true) {
                    idades.Add(idade);
                } else {
                    Console.WriteLine($"A idade do aluno não pode ser nula.");
                }
                if (verifica3 == true) {
                    notas.Add(nota);
                    soma += nota;
                } else {
                    Console.WriteLine($"A nota do aluno não pode ser nula.");
                }
            }
            double media = soma / notas.Count;
            Console.WriteLine($"A média da turma é {media}");   
        }
    }
}