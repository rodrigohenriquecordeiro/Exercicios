using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o
              número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o fim dos dados.*/

            try
            {
                int numero = 0;
                List<int> lstNumeros = new List<int>();
                Console.Write("Digite um número: ");

                while (!int.TryParse(Console.ReadLine(), out numero) || numero >= 0) 
                {
                    if (numero > 0)
                    {
                        lstNumeros.Add(numero);
                        Console.Write("Digite um numero: ");
                    }
                }
                if (numero > 0) lstNumeros.Add(numero);

                Console.WriteLine($"\nResultado: {CalculaMaiorMenor(lstNumeros)}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string CalculaMaiorMenor(List<int> lstNumeros)
        {
            return $"Maior: {lstNumeros.Max()}" +
                $"\nMenor: {lstNumeros.Min()}";
        }
    }
}
