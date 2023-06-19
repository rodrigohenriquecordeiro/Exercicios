using System;

namespace Ex062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que calcule e retorne o valor da hipotenusa através do método HIPOTENUSA. O método
              recebe o valor da base e da altura de um triângulo.*/

            try
            {
                Console.Write("Digite o valor da Base: "); double valorBase = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor da Altura: "); double valorAltura = double.Parse(Console.ReadLine());
                Console.WriteLine($"\nHipotenusa: {CalculaHipotenusa(valorBase, valorAltura)}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            static string CalculaHipotenusa(double valorBase, double valorAltura)
            {
                return Math.Sqrt(valorBase * valorBase + valorAltura * valorAltura).ToString();
            }
        }
    }
}
