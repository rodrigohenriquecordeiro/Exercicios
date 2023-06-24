using System;
using System.Linq;

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
                int escolha = 0;

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
                    
                    while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 7)
                    {
                        Console.WriteLine("\nOpção inválida!");
                        Console.Write("Digite novamente sua escolha: ");
                    }

                    if (escolha == 1)
                        vetor = CarregarVetor();

                    if (escolha == 2)
                        ListarVetor(vetor);

                    if (escolha == 3)
                        Par(vetor);

                    if (escolha == 4)
                        Impar(vetor);

                    if (escolha == 5)
                        QuantidadePar(vetor);

                    if (escolha == 6)
                        QuantidadeImpar(vetor);

                    if (escolha == 7)
                        break;
                }

                Console.WriteLine("Fim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }                    
        }

        private static void QuantidadeImpar(int[] vetor)
        {
            int quantidadeImpar = 0;
            Console.WriteLine("Quantidade de números ímpares existem nas posições pares do vetor");
            for (int i = 0; i < vetor.Length;)
            {
                if (vetor[i] % 2 != 0)
                    quantidadeImpar++;
                i += 2;
            }
            Console.WriteLine($"Resultado: {quantidadeImpar}");
        }

        private static void QuantidadePar(int[] vetor)
        {
            int quantidadePar = 0;
            Console.WriteLine("Quantidade de números pares existem nas posições ímpares do vetor");
            for (int i = 0; i < vetor.Length;)
            {
                if (vetor[i] % 2 == 0)
                    quantidadePar++;
                i += 2;
            }
            Console.WriteLine($"Resultado: {quantidadePar}");
        }

        private static void Impar(int[] vetor)
        {
            Console.WriteLine("Números ímpares");
            foreach (var numero in vetor.ToList().Where(x => x % 2 != 0))
            {
                Console.WriteLine(numero);
            }
        }

        private static void Par(int[] vetor)
        {
            Console.WriteLine("Números pares");
            foreach (var numero in vetor.ToList().Where(x => x % 2 == 0))
            {
                Console.WriteLine(numero);
            }
        }

        private static void ListarVetor(int[] vetor)
        {
            foreach (var numero in vetor)
            {
                Console.WriteLine(numero);
            }
        }

        private static int[] CarregarVetor()
        {
            int[] vetor;
            Console.Write("\nQual o tamanho do vetor? ");
            int tamanho = int.Parse(Console.ReadLine());
            vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"{i}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            return vetor;
        }
    }
}
