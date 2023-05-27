using System;

namespace Ex027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia:
              - a quantidade de números que deverá processar;
              - os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial.
              Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N*/

            try
            {
                Console.Write("Qual a quantidade de números para processar? "); int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {Fatorial(num)}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string Fatorial(int num)
        {
            int fatorial = 1;

            for (int i = 1; i <= num; i++)
            {
                fatorial *= i;
            }

            return fatorial.ToString();
        }
    }
}
