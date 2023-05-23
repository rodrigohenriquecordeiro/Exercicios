using System;

namespace Ex006
{
    internal class Program
    {
        const char simboloGraus = '\u00B0';

        static void Main(string[] args)
        {
            /*Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de
              temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
              Fahrenheit e a variável C representa é a temperatura em graus Celsius.*/

            try
            {
                Console.Write("Qual a temperatura em Graus Celsius? "); double celsius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{celsius}{simboloGraus + "C"} são {CalculaFahrenheit(celsius)}.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string CalculaFahrenheit(double celsius)
        {
            return ((9 * celsius + 160) / 5).ToString() + simboloGraus + "F";
        }
    }
}
