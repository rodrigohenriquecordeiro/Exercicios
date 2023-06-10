using System;
using System.Linq;

namespace Ex047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Considere um vetor de 10 números inteiros positivos maiores que zero e um único número inteiro, também positivo
              e maior que zero. Faça um programa para:
              a. ler pelo teclado o vetor;
              b. ler pelo teclado o número X;
              c. dizer quantos números no vetor são maiores que X, menores que X e iguais a X.*/

            try
            {
                int x;
                Console.Write("Digite o valor de x: ");
                while (!int.TryParse(Console.ReadLine(), out x) || x == 0)
                {
                    Console.WriteLine("Número inválido, tente novamente");
                    Console.Write("\nDigite o valor de x: ");
                }

                int[] vetor = new int[10];
                Console.WriteLine("\nDigite 10 números inteiros");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Digite o {i + 1}º número: ");

                    while (!int.TryParse(Console.ReadLine(), out vetor[i]) || vetor[i] == 0)
                    {
                        Console.WriteLine("Número inválido, tente novamente");
                        Console.Write($"Digite o {i + 1}º número: ");
                    }
                }

                Console.WriteLine();
                Console.WriteLine(GeraResultado(vetor, x)); 

                Console.WriteLine("\nFim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string GeraResultado(int[] vetor, int x)
        {
            int contadorDeIguais = 0, contadorDeMaior = 0, contadorDeMenor = 0;

            foreach (var numero in vetor)
            {
                if (numero == x) contadorDeIguais++;
                if (numero < x) contadorDeMenor++;
                if (numero > x) contadorDeMaior++;
            }

            return $"Maior: {contadorDeMaior}" +
                $"\nMenor: {contadorDeMenor}" +
                $"\nIguais: {contadorDeIguais}";
        }
    }
}
