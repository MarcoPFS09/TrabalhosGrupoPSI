using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabGrupoM9_Pert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            int[] vetor = new int[N];

            Console.WriteLine($"Digite {N} números inteiros (aperte Enter após cada um):");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{i + 1}: ");
                // tenta ler e converter; repete até valor válido
                while (!int.TryParse(Console.ReadLine(), out vetor[i]))
                {
                    Console.Write("Entrada inválida. Digite um número inteiro: ");
                }
            }

            int indiceMaior = 0;
            int valorMaior = vetor[0];

            for (int i = 1; i < N; i++)
            {
                if (vetor[i] > valorMaior)
                {
                    valorMaior = vetor[i];
                    indiceMaior = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Maior valor: {valorMaior}");
            Console.WriteLine($"Índice (base 0): {indiceMaior}");
            Console.WriteLine($"Índice (base 1): {indiceMaior + 1}");
        }
    }
}
