using System;

namespace Ex026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.*/

            try
            {
                for (int i = 1; i <= 100; i++) Console.WriteLine($"{101 - i}");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
