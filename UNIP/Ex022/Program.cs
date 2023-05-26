using System;

namespace Ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia um número.Se positivo armazene - o em A, se for negativo, em B.No final mostrar o resultado.*/

            try
            {
                string a, b = string.Empty;
                int numero;

                Console.Write("Digite um número: "); int.TryParse(Console.ReadLine(), out numero);

                if (numero >= 0)
                    Console.WriteLine($"A: {a = numero.ToString()}");
                else
                    Console.WriteLine($"B: {b = numero.ToString()}");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
