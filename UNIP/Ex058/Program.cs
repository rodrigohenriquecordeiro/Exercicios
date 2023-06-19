using System;
using System.Linq;

namespace Ex058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média. Imprimir
              também o maior. A quantidade de números lidos será definida pelo usuário.*/

            try
            {
                Console.Write("Quantos números você quer utilizar? "); int quantidade = int.Parse(Console.ReadLine());
                int[] vetor = new int[quantidade];

                for (int i = 1; i <= quantidade; i++)
                {
                    Console.Write($"Digite o {i}º número: ");
                    vetor[i - 1] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"\nMédia: {vetor.Average():F2}" +
                    $"\nMaior: {vetor.Max()}");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
