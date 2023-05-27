using System;

namespace Ex024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja  realizar:
              1 – Verificar se um dos números lidos é ou não múltiplo do outro
              2 – Verificar se os dois números lidos são pares
              3 – Verificar se a média dos dois números é maior ou igual a 7.
              4 – Sair*/

            try
            {
                Console.Write("Digite o primeiro número: "); int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: "); int n2 = int.Parse(Console.ReadLine());

                Console.Write("\n1 – Verificar se um dos números lidos é ou não múltiplo do outro" +
                    "\n2 – Verificar se os dois números lidos são pares" +
                    "\n3 – Verificar se a média dos dois números é maior ou igual a 7." +
                    "\n4 – Sair");

                Console.Write("\nDigite sua escolha: ");
                int escolha = int.Parse(Console.ReadLine());

                Console.WriteLine($"Resultado: {ExecutaOperacao(n1, n2, escolha)}"); 
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string ExecutaOperacao(int n1, int n2, int escolha)
        {
            return escolha switch
            {
                1 => Multiplo(n1, n2),
                2 => Par(n1, n2),
                3 => Media(n1, n2).ToString("F2"),
                _ => ""
            };
        }

        private static double Media(int n1, int n2)
        {
            return (n1 + n2) / 2;
        }

        private static string Par(int n1, int n2)
        {
            if (n1 % 2 == 0 && n2 % 2 == 0)
                return $"{n1} e {n2} são par";
            else if (n1 % 2 == 0 && n2 % 2 != 0)
                return $"{n1} é par e {n2} é ímpar";
            else if (n1 % 2 != 0 && n2 % 2 == 0)
                return $"{n1} é ímpar e {n2} é par";
            else
                return $"{n1} e {n2} são impares";
        }

        private static string Multiplo(int n1, int n2)
        {
            if (n1 % n2 == 0 || n2 % n1 == 0)
                return "É multiplo";
            else
                return "Não é multiplo";
        }
    }
}
