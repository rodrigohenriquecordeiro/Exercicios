using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia 10 valores inteiros e positivos e:
              - Encontre o maior valor
              - Encontre o menor valor
              - Calcule a média dos números lidos*/

            try
            {
                int numero = 0;
                const int limite = 10;
                List<int> lstNumeros = new List<int>();

                Console.Write("Digite um número: ");

                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    lstNumeros.Add(numero);
                    Console.Write("Digite um número: ");
                }
                lstNumeros.Add(numero);
                Console.WriteLine(GeraResultado(lstNumeros)); 
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string GeraResultado(List<int> lstNumeros)
        {
            return $"\nMaior: {lstNumeros.Max()}." +
                $"\nMenor: {lstNumeros.Min()}." +
                $"\nMédia: {lstNumeros.Sum()}.";
        }
    }
}
