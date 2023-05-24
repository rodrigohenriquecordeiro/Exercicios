using System;
using System.Collections.Generic;

namespace Ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está na faixa
              entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”.
              Caso contrário, apresentar a mensagem “valor inválido”.*/

            try
            {
                Console.Write("Digite um número: "); int numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"O número {numero} é {ValidaNumero(numero)}.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string ValidaNumero(int numeroEscolhido)
        {
            List<int> numerosParaValidar = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            foreach (int numero in numerosParaValidar)
                if (numero == numeroEscolhido) return "Válido";

            return "Inválido";
        }
    }
}
