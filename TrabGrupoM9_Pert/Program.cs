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
            Console.WriteLine();
            int[] numeros = new int[10];
            Console.WriteLine($"Digite números inteiros: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{i+1}-");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int maximo = numeros[0];
            int indice = 1;
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                    indice = i;
                }
            }
            Console.WriteLine($"Maior número: {maximo}, índice: {indice + 1}");
            Console.WriteLine("njfibduifgberuifbhuidbguyr");
            
            Console.ReadKey();
            Console.WriteLine("castanho");
          
        }
    }
}