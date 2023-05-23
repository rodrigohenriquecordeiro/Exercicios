using System;

namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
              valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis
              A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
              com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo,
              devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as
              multiplicações.*/

            try
            {
                Console.Write("Digite o valor de A: "); int a = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de B: "); int b = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de C: "); int c = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de D: "); int d = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine($"{a} + {b} = {a + b}");
                Console.WriteLine($"{a} + {c} = {a + c}");
                Console.WriteLine($"{a} + {d} = {a + d}");
                Console.WriteLine($"{b} + {c} = {b + c}");
                Console.WriteLine($"{b} + {d} = {b + d}");
                Console.WriteLine($"{c} + {d} = {c + d}");

                Console.WriteLine($"{a} * {b} = {a * b}");
                Console.WriteLine($"{a} * {c} = {a * c}");
                Console.WriteLine($"{a} * {d} = {a * d}");
                Console.WriteLine($"{b} * {c} = {b * c}");
                Console.WriteLine($"{b} * {d} = {b * d}");
                Console.WriteLine($"{c} * {d} = {c * d}");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
