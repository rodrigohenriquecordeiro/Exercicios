using System;

namespace Ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia um número inteiro e exiba o seu módulo.
              O módulo de um número x é:
              x se x é maior ou igual a zero
              x * (-1) se x é menor que zero*/

            try
            {
                Console.Write("Digite um número inteiro: "); int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"O módulo do número {num} é {CalculaModulo(num)}.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string CalculaModulo(int num)
        {
            if (num >= 0)
                return "x";
            else 
                return "*";
        }
    }
}
