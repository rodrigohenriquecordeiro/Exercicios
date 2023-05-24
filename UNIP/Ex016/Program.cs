using System;

namespace Ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do
              menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.*/

            try
            {
                Console.Write("Primeiro número: "); int num1 = int.Parse(Console.ReadLine());
                Console.Write("Segundo número: "); int num2 = int.Parse(Console.ReadLine());

                if (num1 == num2)
                    Console.WriteLine("Iguais");
                else if (num1 > num2)
                    Console.WriteLine("Primeiro é maior");
                else
                    Console.WriteLine("Segundo é maior");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
