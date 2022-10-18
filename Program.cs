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
            double somaNotas = 0.0;
            Console.Write($"Insira a quantidade de alunos da turma: ");
            string? valor = Console.ReadLine();
            int tam;
            bool valida = int.TryParse(valor, out tam);
            if (valida == true) {
                for (int i = 0; i < tam; i++) {
                    Console.Write($"Digite o nome do {i+1}º aluno: ");
                    string? entrada1 = Console.ReadLine();
                    Console.Write($"Digite a idade do {i+1}º aluno: ");
                    string? entrada2 = Console.ReadLine();
                    Console.Write($"Digite a nota do {i+1}º aluno: ");
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
                        somaNotas += nota;
                    } else {
                        Console.WriteLine($"A nota do aluno não pode ser nula.");
                    }
                }
                double mediaNotas = (somaNotas / tam) / 10;
                Console.WriteLine($"A média das notas da turma é {mediaNotas}");
                double maiorNota = 0;
                for (int j = 0; j < tam; j++) {
                    if (notas[j] > maiorNota) {
                        maiorNota = notas[j];
                    }
                }
                Console.WriteLine($"A maior nota foi {maiorNota/10}");
                Console.WriteLine($"Os nomes dos alunos em ordem alfabética são: ");
                nomes.Sort();
                foreach (string nome in nomes)
                {
                    Console.WriteLine(nome);
                }
                Console.WriteLine($"As idades dos alunos em ordem crescente são: ");
                idades.Sort();
                foreach (int idade in idades)
                {
                    Console.WriteLine(idade);
                }
                Console.WriteLine($"As notas dos alunos em ordem crescente são: ");
                notas.Sort();
                foreach (double nota in notas)
                {
                    Console.WriteLine(nota/10);
                }
            } else {
                Console.WriteLine($"A quantidade de alunos precisa ser um valor válido.");
            }
        }
    }
}