using System;

namespace Ex029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que exiba os números de 1 até 2000.*/

            try
            {
                for (int i = 1; i <= 2000; i++)
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
