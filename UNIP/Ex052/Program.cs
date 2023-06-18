using System;
using System.Linq;

namespace Ex052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o número 1, 3 e 4, nesta
              ordem. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1.*/

            try
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] sequencia = { 3, 4, 5 };

                int sequenciaLength = sequencia.Length;
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == sequencia[count])
                    {
                        count++;

                        if (count == sequenciaLength)
                        {
                            Console.WriteLine("Sequência encontrada na posição {0}", i - sequenciaLength + 1);
                            break;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }

                if (count != sequenciaLength)
                {
                    Console.WriteLine("Sequência não encontrada");
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
