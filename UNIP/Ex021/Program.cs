using System;

namespace Ex021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é
              positivo ou negativo. Pare a execução do programa quando o usuário requisitar.*/

            try
            {
                int numero;
                
                Console.Write("Digite um número: ");
                while (int.TryParse(Console.ReadLine(), out numero)) 
                {
                    if (numero.ToString() == "*")
                        break;
                    Console.WriteLine($"{numero} é {GeraNumero(numero)}");
                    Console.Write("\nDigite um número: ");
                }
                Console.WriteLine("\nFim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string GeraNumero(int numero)
        {
            if (numero >= 0)
                return "Positivo";
            else
                return "Negativo";
        }
    }
}
