using System;
using System.Numerics;

namespace Ex043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria qualquer preço. O monge, necessitando
              de alimentos, indagou à rainha sobre o pagamento, se poderia ser feito com grãos de trigo dispostos em um
              tabuleiro de xadrez, de tal forma que o primeiro quadro deveria conter apenas um grão e os quadros
              subseqüentes, o dobro do quadro anterior. A rainha achou o trabalho barato e pediu que o serviço fosse
              executado, sem se dar conta de que seria impossível efetuar o pagamento. Faça um programa para calcular o
              número de grãos que o monge esperava receber.*/

            try
            {
                BigInteger graos = 1;

                Console.WriteLine($"1º {graos}");
                for (int i = 1; i < 64; i++)
                {
                    graos *= 2;
                    Console.WriteLine($"{i + 1}º {graos}");
                }

                Console.WriteLine("\nFim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
