using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex007
{
    internal class Program
    {
        const char simboloGraus = '\u00B0';

        static void Main(string[] args)
        {
            /*Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de
              temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a
              variável C é a temperatura em graus Celsius.*/

            try
            {
                Console.Write("Qual a temperatura em Graus Fahrenheit? "); double fahrenheit = double.Parse(Console.ReadLine());
                Console.WriteLine($"{fahrenheit}{simboloGraus + "F"} são {CalculaCelsius(fahrenheit)}.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string CalculaCelsius(double fahrenheit)
        {
            return ((fahrenheit - 32) * 5 / 9).ToString("F2") + simboloGraus + "C";
        }
    }
}
