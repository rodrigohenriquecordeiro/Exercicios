using System;

namespace Ex063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que verifique se um número é par ou ímpar através de um método chamado VERIFICA. O
              método deverá receber um número inteiro (n) e deverá retornar a mensagem “PAR” ou “ÍMPAR”.*/

            try
            {
                Console.Write("Digite um número: "); int numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {ParOuImpar(numero)}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            static string ParOuImpar(int numero)
            {
                if (numero % 2 == 0)
                    return "PAR";
                else
                    return "ÍMPAR";
            }
        }
    }
}
