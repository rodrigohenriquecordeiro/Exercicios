using System;

namespace Ex023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas:
              1 – Adição
              2 – Subtração
              3 – Multiplicação
              4 – Divisão*/

            try
            {
                Console.Write("Operações Disponíveis" +
                    "\n1. Adição" +
                    "\n2. Subtração" +
                    "\n3. Multiplicação" +
                    "\n4. Divisão" +
                    "\nDigite o número da sua escolha: ");
                string escolha = Console.ReadLine();

                Console.WriteLine();
                Console.Write("1º número: "); double n1 = double.Parse((Console.ReadLine()));
                Console.Write("2º número: "); double n2 = double.Parse((Console.ReadLine()));
                Console.WriteLine($"Resultado: {Calculadora(escolha, n1, n2)}");

                Console.WriteLine("\nFim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string Calculadora(string escolha, double n1, double n2)
        {
            return escolha switch
            {
                "1" => Adicao(n1, n2),
                "2" => Subtracao(n1, n2),
                "3" => Multiplicacao(n1, n2),
                "4" => Divisao(n1, n2),
                _ => "Opção errada"
            };
        }

        private static string Adicao(double n1, double n2)
        {
            return (n1 + n2).ToString();
        }

        private static string Subtracao(double n1, double n2)
        {
            return (n1 - n2).ToString();
        }

        private static string Multiplicacao(double n1, double n2)
        {
            return (n1 * n2).ToString();
        }
        
        private static string Divisao(double n1, double n2)
        {
            return (n1 / n2).ToString();
        }
    }
}
