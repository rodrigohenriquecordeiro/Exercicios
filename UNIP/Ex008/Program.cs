using System;

namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
              V = 3.14159 * R * R * A
              Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.*/

            try
            {
                Console.Write("Qual o Raio da lata? "); double raio = double.Parse(Console.ReadLine());
                Console.Write("Qual o Altura da lata? "); double altura = double.Parse(Console.ReadLine());

                Console.WriteLine($"O volume da lata de óleo é {CalculaVolume(raio, altura)}");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }        
        }

        private static string CalculaVolume(double raio, double altura)
        {
            return (3.14159 * raio * raio * altura).ToString("F2");
        }
    }
}
