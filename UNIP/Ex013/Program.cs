using System;
using System.Linq;

namespace Ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.*/

            try
            {
                Console.Write("1º número: "); int n1 = int.Parse(Console.ReadLine());
                Console.Write("2º número: "); int n2 = int.Parse(Console.ReadLine());
                Console.Write("3º número: "); int n3 = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nNúmeros Ordenadores: {OrdenaNumeros(n1, n2, n3)}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string OrdenaNumeros(params int[] numerosEscolhidos)
        {
            string resultado = string.Empty;
            foreach (int numero in numerosEscolhidos.OrderByDescending(x => x).ToList()) 
            {
                resultado += (numero + ", ").ToString();
            }
            return resultado.Substring(0, resultado.Trim().Length - 1);
        }
    }
}
