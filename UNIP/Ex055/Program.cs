using System;

namespace Ex055
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa que leia uma frase de até 50 caracteres e imprima a frase sem os espaços em branco.
              Imprimir também a quantidade de espaços em branco da frase.*/

            try
            {
                string frase = "Antes de P e B, só M devo escrever. Antes das outras letras, só o N meio perneta!";
                int contador = 0;

                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == ' ') contador++;
                }

                Console.WriteLine($"{frase.Replace(" ", "")}" +
                    $"\nQuantidade de espaços: {contador}");

                Console.WriteLine("Fim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
