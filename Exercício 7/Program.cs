using System;
using System.Globalization;
namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma, media;
            soma = 0;
            media = 0;
            string[] nome;
            double[] notas;
            double[] notas1;

            int n = int.Parse(Console.ReadLine());

            nome = new string[n];
            notas = new double[n];
            notas1 = new double[n];

            for(int i = 0;i<n;i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                nome[i] = vetor[0];
                notas[i] = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                notas1[i] = double.Parse(vetor[2], CultureInfo.InvariantCulture);


            }
            Console.WriteLine();
            Console.WriteLine("Alunos aprovados ");
            for (int i=0;i<n;i++)
            {
                media = (notas[i] + notas1[i]) / 2.0;
                if (media>=6)
                {
                    Console.WriteLine(nome[i]);
                    
                }
            }
        }
    }
}
