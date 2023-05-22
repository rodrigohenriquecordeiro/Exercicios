using System;

namespace Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /* Faça um programa para calcular o estoque médio de uma peça, sendo que:
                   ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.") */

                Console.Write("Digite a Quantidade Mínima: "); int quantidadeMinima = int.Parse(Console.ReadLine().Trim());
                Console.Write("Digite a Quantidade Máxima: "); int quantidadeMaxima = int.Parse(Console.ReadLine().Trim());

                Console.WriteLine($"\nQuantidade Mínima: {quantidadeMinima}. " +
                    $"\nQuantidade Máxima: {quantidadeMaxima}. " +
                    $"\nEstoque Médio: {CalculaEstoqueMedio(quantidadeMinima, quantidadeMaxima)}.");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static int CalculaEstoqueMedio(int quantidadeMinima, int quantidadeMaxima)
        {
            return (quantidadeMinima + quantidadeMaxima) / 2;
        }
    }
}
