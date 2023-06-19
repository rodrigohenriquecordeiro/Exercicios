using System;
using System.Runtime.CompilerServices;

namespace Ex060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que retorne o número do quadrante (1,2,3 ou 4) através de um método chamado
              VERIFICA_QUADRANTE, que deve receber um valor para x e um valor para y.*/

            try
            {
                Console.Write("Digite o valor de x: "); int x = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de y: "); int y = int.Parse(Console.ReadLine());
                Console.WriteLine(VerificaQuadrante(x, y)); 
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            static string VerificaQuadrante(int x, int y)
            {
                return $"{VerificaX(x)}" +
                    $"\n{VerificaY(y)}";

                string VerificaX(int x)
                {
                    if (x > 0) return $"{x} é do 1º quadrante";
                    else return $"{x} é do 4º quadrante";
                }

                string VerificaY(int y)
                {
                    if (y > 0) return $"{y} é do 2º quadrante";
                    else return $"{y} é do 3º quadrante";
                }
            }
        }
    }
}
