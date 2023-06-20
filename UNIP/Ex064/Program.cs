using System;

namespace Ex064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que deverá ter as seguintes opções:
              1 - Carregar Vetor
              2 - Listar Vetor
              3 - Exibir apenas os números pares do vetor
              4 - Exibir apenas os números ímpares do vetor
              5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor
              6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor
              7 - Sair
              Deverá ser implementado um método para realizar cada uma das opções de 1 a 6*/

            try
            {
                int[] vetor = null;

                while (true)
                {
                    Console.Write("OPÇÕES:" +
                        "\n1 - Carregar Vetor" +
                        "\n2 - Listar Vetor" +
                        "\n3 - Exibir apenas os números pares do vetor" +
                        "\n4 - Exibir apenas os números ímpares do vetor" +
                        "\n5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor" +
                        "\n6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor" +
                        "\n7 - Sair" +
                        "\nDigite sua escolha: ");

                    int escolha = 0;
                    while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 7)
                    {
                        Console.WriteLine("\nOpção inválida!");
                        Console.Write("Digite novamente sua escolha: ");
                    }

                    if (escolha == 1)
                    {
                        CarregarVetor(vetor);
                    }

                    

                    if (escolha == 2)
                        ListarVetor(vetor);

                    //1 => CarregarVetor(),
                    //2 => ListarVetor(),
                    //3 => Par(),
                    //4 => Impar(),
                    //5 => QuantidadeImpares(),
                    //6 => QuantidadePares(),    
                }


                Console.WriteLine("Fim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }                    

            static int[] CarregarVetor(int[] vetor)
            {
                Console.Write("Qual o tamanho do vetor? ");
                int tamanho = int.Parse(Console.ReadLine());
                vetor = new int[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write($"{i + 1}º número: ");
                    vetor[i] = int.Parse(Console.ReadLine());
                }

                return vetor;
            }

            static void ListarVetor(int[] vetor)
            {
                foreach (var numero in vetor)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
