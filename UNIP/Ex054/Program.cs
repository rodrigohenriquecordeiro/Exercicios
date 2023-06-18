using System;
using System.Collections.Generic;

namespace Ex054
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa que imprima todos os elementos comuns aos dois vetores*/

            try
            {
                int[] a = new int[5] { 1, 2, 3, 4, 5};
                int[] b = new int[8] { 2, 3, 5, 6, 7, 8, 9, 10};
                List<int> lista = new List<int>();

                foreach (var numero in a) foreach (var item in b) if (numero == item) lista.Add(item);
                
                foreach (var item in lista) Console.Write($"{item}, ");

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
