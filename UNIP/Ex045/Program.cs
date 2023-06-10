using System;
using System.Linq;

namespace Ex045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa que foi realizada a leitura.*/

            try
            {
                int[] vetor = new int[5];
                Console.WriteLine("Digite 5 números inteiros\n");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{i + 1}º número: ");
                    vetor[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
                foreach (var numero in vetor.Reverse())
                {
                    Console.WriteLine($"Inversa: {numero}");
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
}
