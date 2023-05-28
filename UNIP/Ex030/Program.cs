using System;

namespace Ex030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para imprimir uma tabuada.*/

            try
            {
                Console.Write("Qual tabuada você quer imprimir? "); int tabuada = int.Parse(Console.ReadLine());
                GeraTabuada(tabuada);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static void GeraTabuada(int tabuada)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {tabuada} = {i * tabuada}");
            }
        }
    }
}
