using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Ex042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que determine o maior e o menor entre N números lidos. A condição de parada é a entrada de
               um valor 0, ou seja, o programa deve ficar executando até que a entrada seja igual a 0 (ZERO).*/

            try
            {
                List<int> lstNumeros = new List<int>();

                Console.Write("Digite um número inteiro: ");
                while (int.TryParse(Console.ReadLine(), out int numero))
                {
                    lstNumeros.Add(numero);
                    if (numero == 0)
                    {
                        lstNumeros.Remove(0);
                        break;
                    }
                    Console.Write("Digite um número inteiro: ");
                }
                Console.WriteLine($"\n{GeraResultado(lstNumeros)}"); 
                Console.WriteLine("\nFim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string GeraResultado(List<int> lstNumeros)
        {
            return $"\nA lista possui {lstNumeros.Count} elementos" +
                $"\nMaior Número: {lstNumeros.Max()}" +
                $"\nMenor Número: {lstNumeros.Min()}";
        }
    }
}
