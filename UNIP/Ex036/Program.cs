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
                List<int> lstNumeros = new List<int>();

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"Digite o {i}º número: ");
                    while (!NumeroRecebidoValido(out numero))
                    {
                        Console.WriteLine($"\n***Opção inválida, tente novamente***");
                        Console.Write($"\nDigite o {i}º número: ");
                    }
                    lstNumeros.Add(numero);
                }

                Console.WriteLine(GeraResultado(lstNumeros)); 
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static bool NumeroRecebidoValido(out int numero)
        {
            return int.TryParse(Console.ReadLine(), out numero);
        }

        private static string GeraResultado(List<int> lstNumeros)
        {
            return $"\nMaior: \t{lstNumeros.Max()}" +
                $"\nMenor: \t{lstNumeros.Min()}" +
                $"\nSoma: \t{lstNumeros.Sum()}" +
                $"\nMédia: \t{lstNumeros.Sum() / lstNumeros.Count:F0}";
        }
    }
}
