using System;

namespace Ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia dois números e apresente a diferença do maior para o menor.*/

            try
            {
                Console.Write("1º número: "); int num1 = int.Parse(Console.ReadLine());
                Console.Write("2º número: "); int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nA diferença entre {num1} e {num2} é {CalculaDiferenca(num1, num2)}.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static int CalculaDiferenca(int num1, int num2)
        {
            if (num1 > num2)
                return num1 - num2;
            else
                return num2 - num1;
        }
    }
}
