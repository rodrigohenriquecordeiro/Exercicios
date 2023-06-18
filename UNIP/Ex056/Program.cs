using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um vetor de inteiros de 50 posições. Imprimir a quantidade de números pares e de múltiplos de 5.*/

            try
            {
                int[] vetor = new int[20] { 1, 2, 3, 36, 45, 36, 21, 586, 14, 236, 125, 154, 52, 2165, 20, 36, 40, 50, 56, 36 };
                string resultado = string.Empty;
                
                foreach (var numero in vetor)
                {
                    if (numero % 2 == 0 && numero % 5 == 0)
                        resultado += numero.ToString() + ", ";
                }
                Console.WriteLine($"Resultado: {resultado.Substring(0, resultado.Trim().Count() - 1)}");

                Console.WriteLine("Fim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
