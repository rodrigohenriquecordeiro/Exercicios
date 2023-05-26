using System;

class Program
{
    static void Main(string[] args)
    {
        /*Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada
          variável (se o valor digitado não é válido, mostrar mensagem e ler novamente).*/

        try
        {
            int a, b, c;

            Console.WriteLine("Digite três valores inteiros maiores que zero:");

            Console.Write("Valor para 'a': ");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.Write("Valor inválido! Digite novamente para 'a':");
            }

            Console.Write("Valor para 'b': ");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.Write("Valor inválido! Digite novamente para 'b':");
            }

            Console.Write("Valor para 'c': ");
            while (!int.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.Write("Valor inválido! Digite novamente para 'c':");
            }

            Console.WriteLine($"Valores lidos: a = {a}, b = {b}, c = {c}");

            Console.ReadLine();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
