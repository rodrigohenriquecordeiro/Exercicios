using System;

namespace Ex050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa que sorteie um número de 0 a 100 e que permita que o usuário (sem conhecer o número
              sorteado) tente acertar. Caso não acerte, o programa deve imprimir uma mensagem informando se o número
              sorteado é maior ou menor que a tentativa feita. Ao acertar o número, o programa deve imprimir a quantidade de
              tentativas feitas.*/

            try
            {
                Random numero = new Random();
                int sorteio = numero.Next(15);
                int tentativas = 0;

                Console.Write("Sua escolha: "); int escolha = int.Parse(Console.ReadLine());
                tentativas++;

                while (escolha != sorteio)
                {
                    Console.WriteLine("Número errado!");
                    Console.Write("\nSua escolha: "); escolha = int.Parse(Console.ReadLine());
                    tentativas++;
                }
                Console.WriteLine($"Párabens, você acertou o número {sorteio}" +
                    $"\nForam necessárias {tentativas} tentativas");
                
                Console.WriteLine($"Fim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
