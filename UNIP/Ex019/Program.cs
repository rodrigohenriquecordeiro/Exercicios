using System;

namespace Ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). Verificar se cada
               lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e se B==C, sendo verdade o triângulo é
               eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso
               contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a
               ocorrência.*/

            try
            {
                Console.Write("Digite o valor de A: "); double a = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor de B: "); double b = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor de C: "); double c = double.Parse(Console.ReadLine());

                Console.WriteLine($"\nTriângulo {VerificaTipoTriangulo(a, b, c)}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static object VerificaTipoTriangulo(double a, double b, double c)
        {
            if (TrianguloPossivel(a, b, c))
            {
                if (a == b && b == c) return "Equilatero";
                else if (a == b || a == c || b == c) return "Isóceles";
                else return "Escaleno";
            }
            else 
                return "Inválido";
        }

        private static bool TrianguloPossivel(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > c;
        }
    }
}
