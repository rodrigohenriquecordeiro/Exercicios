using System;

namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes
              entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.*/

            try
            {
                Console.Write("1º Número: "); int num1 = int.Parse(Console.ReadLine());
                Console.Write("2º Número: "); int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"O relacionamento entre {num1} e {num2}: {CalculaRelacionamentos(num1, num2)}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string CalculaRelacionamentos(int num1, int num2)
        {
            if (num1 == num2)
                return "São Iguais";
            else if (num1 > num2)
                return "Primeiro é Maior do que o Segundo";
            else
                return "Segundo é Maior do que o Primeiro";
        }
    }
}
