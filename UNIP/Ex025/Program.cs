using System;

namespace Ex025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal,
             * utilizando as seguintes fórmulas: (h = altura)
            - Para homens: (72.7*h) - 58
            - Para mulheres: (62.1 *h) - 44.7*/

            try
            {
                Console.Write("Qual a sua altura? "); double altura = double.Parse(Console.ReadLine());
                Console.Write("Qual o seu sexo? "); char sexo = char.Parse(Console.ReadLine());

                if (sexo == 'M')
                    Console.WriteLine($"\nPeso ideal: {72.7 * altura - 58:F2}.");

                if (sexo == 'F')
                    Console.WriteLine($"\nPeso ideal: {62.1 * altura - 44.7:F2}.");

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
