using System;

namespace Ex039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar,
              e se é positivo ou negativo. O programa só deve parar de rodar quando o usuário responder "S" na seguinte
              pergunta, "Deseja encerrar o programa?" .*/

            try
            {
                while (true)
                {
                    Console.Write("Digite um número inteiro: "); int numero = int.Parse(Console.ReadLine());
                    Console.WriteLine(PositivoOuNegativo(numero));
                    Console.WriteLine(ParOuImpar(numero));
                    Console.Write("\nDeseja encerrar o programa? "); string continuar = Console.ReadLine();
                    if (continuar.ToUpper() == "S")
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

        private static string PositivoOuNegativo(int numero)
        {
            if (numero < 0)
                return $"O número {numero} é negativo.";
            else
                return $"O número {numero} é positivo.";
        }

        private static string ParOuImpar(int numero)
        {
            if (numero % 2 == 0)
                return $"O número {numero} é Par.";
            else
                return $"O número {numero} é Ímpar.";
        }
    }
}
