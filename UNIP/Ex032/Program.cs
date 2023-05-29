using System;

namespace Ex032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos
              ímpares a partir do número informado pelo usuário menor que 10 e maior que zero.*/

            try
            {
                int numeroDigitado = 0;
                Console.Write("Digite um número maior do que 0 e menor do que 10: ");

                while (ValidaNumero(out numeroDigitado))
                {
                    Console.Write("\nInválido, tente novamente: ");
                }
                Console.WriteLine($"\nNúmero escolhido: {numeroDigitado}");
                Console.WriteLine($"Resultado: {GeraResultado(numeroDigitado)}");

                Console.WriteLine("Fim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static bool ValidaNumero(out int numeroDigitado)
        {
            return !int.TryParse(Console.ReadLine(), out numeroDigitado) && numeroDigitado > 0 && numeroDigitado <= 10;
        }

        private static string GeraResultado(int numeroDigitado)
        {
            int soma = 0;
            for (int i = numeroDigitado; i <= 20; i++)
            {
                if (numeroImpar(numeroDigitado))
                {
                    soma += numeroDigitado * numeroDigitado;
                }
            }

            return soma.ToString(); 
        }

        private static bool numeroImpar(int numeroDigitado)
        {
            return numeroDigitado % 2 != 0;
        }
    }
}
