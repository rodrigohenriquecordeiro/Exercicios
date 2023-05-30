using System;

namespace Ex035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10".*/

            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (10 % i == 0)
                        Console.WriteLine($"{i} é Multiplo de 10");
                    else Console.WriteLine(i);
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
