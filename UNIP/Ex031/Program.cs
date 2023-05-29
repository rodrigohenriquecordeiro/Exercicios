using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar. Exiba
              ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos. Suporemos que o
              número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o
              fim dos dados.*/

            try
            {
                int numeros = 0;
                List<int> listaDeNumeros = new List<int>();

                Console.WriteLine("Digite vários números, quando terminar tecle -1.");
                
                while (numeros > -1) 
                {
                    Console.Write("Número: "); numeros = int.Parse(Console.ReadLine());
                    listaDeNumeros.Add(numeros);
                }

                string numerosEscolhidos = string.Empty;
                foreach (var item in listaDeNumeros.OrderBy(x => x).ToList())
                {
                    if (item > -1) numerosEscolhidos += item + ", ";
                }
                Console.WriteLine($"\nNúmeros escolhidos: {numerosEscolhidos.Substring(0, numerosEscolhidos.Trim().Length - 1)}");

                Console.WriteLine(GeradorDeNumeros(listaDeNumeros)); 
                Console.WriteLine("Fim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string GeradorDeNumeros(List<int> numeros)
        {
            int par = 0, impar = 0;
            
            foreach (var item in numeros.Where(x => x > 0).ToList())
            {
                if (item % 2 == 0)
                    par += item;
                else
                    impar += item;
            }

            return $"\nSoma dos números pares = {par}." +
                $"\nSoma dos números ímpares = {impar}.";
        }
    }
}
