using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            /*Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha
              idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. Foram
              inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações foram armazenadas em
              2 vetores distintos. Faça um programa para imprima o vetor que contém os nomes das candidatas aptas a
              concorrer a uma vaga para a campanha milionária*/

            string[] nomes = new string[20];
            int[] idades = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Informe o nome da candidata {i + 1}: "); nomes[i] = Console.ReadLine();
                Console.WriteLine($"Informe a idade da candidata {i + 1}:"); idades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nCandidatas aptas para a campanha milionária:");
            for (int i = 0; i < 20; i++)
            {
                if (idades[i] >= 18 && idades[i] <= 20)
                    Console.WriteLine(nomes[i]);
            }
            Console.WriteLine("Fim");
            Console.ReadLine();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
