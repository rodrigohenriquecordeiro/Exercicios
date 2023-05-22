using System;

namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua
               comissão será de 5% do total da venda e que você tem os seguintes dados:
                - Preço unitário da peça
                - Quantidade vendida */

            try
            {
                Console.Write("Qual o preço unitário da peca? R$ "); decimal precoUnitario = decimal.Parse(Console.ReadLine());
                Console.Write("Quantas peças foram vendidas? "); int pecasVendidas = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nComissão Recebida: {CalculaComissao(precoUnitario, pecasVendidas)}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string CalculaComissao(decimal precoUnitario, int pecasVendidas)
        {
            const decimal comissao = 0.05m;
            return $"{precoUnitario * pecasVendidas * comissao:C}".ToString();
        }
    }
}
