using System;

namespace Ex028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.*/

            try
            {
                for (int i = 99; i <= 200; i += 2)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
