using System;

namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa
              pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.*/

            try
            {
                Console.Write("Qual a sua data de nascimento? "); DateTime nascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine($"Você viveu {CalculaIdadeEmDias(nascimento)} dias desde o seu nascimento.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string CalculaIdadeEmDias(DateTime nascimento)
        {
            return DateTime.Now.Subtract(nascimento).TotalDays.ToString("F0");
        }
    }
}
