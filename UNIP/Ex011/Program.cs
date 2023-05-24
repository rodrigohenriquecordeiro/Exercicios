using System;

namespace Ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a
               possuir o valor da variável B, e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.*/

            try
            {
                Console.Write("Primeiro número: "); int a = int.Parse(Console.ReadLine());
                Console.Write("Segundo número: "); int b = int.Parse(Console.ReadLine());

                var c = a;
                a = b;
                Console.WriteLine($"Primeiro número trocado: {a}");

                b = c;
                Console.WriteLine($"Segundo número trocado: {b}");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
