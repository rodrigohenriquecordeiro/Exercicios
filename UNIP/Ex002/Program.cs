using System;

namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que:
                - Leia a cotação do dólar
                - Leia um valor em dólares
                - Converta esse valor para Real
                - Mostre o resultado */

            try
            {
                Console.Write("Cotação em Reais do Dólar Americano hoje: R$ "); decimal cotacaoDolar = decimal.Parse(Console.ReadLine());
                Console.Write("Quantos Dólares vocês pretende converter? $ "); decimal dolarParaConverter = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"\n{cotacaoDolar:C} doláres foram convertidos para " +
                    $"{DolarConvertidoParaReal(cotacaoDolar, dolarParaConverter)}.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string DolarConvertidoParaReal(decimal cotacaoDolar, decimal dolarParaConverter)
        {
            return $"{dolarParaConverter * cotacaoDolar:C}";
        }
    }
}
