using System;

class Program
{
    static void Main(string[] args)
    {
        /*Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50). Determine e imprima quantas vezes
          que V1 e V2 possuem valores idênticos nas mesmas posições.*/

        try
        {
            Console.WriteLine("Informe o tamanho dos vetores (até 50):");
            int tamanho = int.Parse(Console.ReadLine());

            int[] V1 = new int[tamanho];
            int[] V2 = new int[tamanho];

            Console.WriteLine("Informe os valores do primeiro vetor (V1):");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Informe o valor para a posição {i}:"); V1[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Informe os valores do segundo vetor (V2):");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Informe o valor para a posição {i}:"); V2[i] = int.Parse(Console.ReadLine());
            }

            int contador = 0;

            for (int i = 0; i < tamanho; i++)
            {
                if (V1[i] == V2[i])
                    contador++;
            }

            Console.WriteLine($"Quantidade de valores idênticos nas mesmas posições: {contador}");
            Console.WriteLine("Fim");
            Console.ReadLine();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
