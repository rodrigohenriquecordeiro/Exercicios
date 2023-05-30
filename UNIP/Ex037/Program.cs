using System;
using System.Runtime.CompilerServices;

namespace Ex037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de entrada com as
              seguintes opções:
              1 – Adição
              2 – Subtração
              3 – Multiplicação
              4 – Divisão
              Informe a opção:
              A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois números. Em seguida, o
              programa deve exibir o resultado da opção indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao
              menu principal. Caso a resposta seja ´S´ ou ´s´, deverá voltar ao menu, caso contrário deverá encerrar o programa.*/

            try
            {
                int numeroDeEntrada = 0, primeiroNumero = 0, segundoNumero = 0;
                
                while (true)
                {
                    Console.WriteLine(">--->Calculadora<---<\n");
                    Menu();

                    while (!ValidaMenu(out numeroDeEntrada))
                    {
                        Console.Clear();
                        Console.WriteLine("Opção errada, tente novamente");
                        Menu();
                    }
                    Console.Clear();

                    Console.Write("1º número: ");
                    while (!ValidaNumero(out primeiroNumero))
                    {
                        Console.WriteLine("Opção errada, tente novamente");
                        Console.Write("1º número: ");
                    }

                    Console.Write("2º número: ");
                    while (!ValidaNumero(out segundoNumero))
                    {
                        Console.WriteLine("Opção errada, tente novamente");
                        Console.Write("2º número: ");
                    }

                    Console.WriteLine($"\nResultado: {Calculadora(numeroDeEntrada, primeiroNumero, segundoNumero)}");
                    Console.Write("\nFazer outro cálculo? Sim ou Não: ");
                    if (Console.ReadLine().Trim().ToUpper().Substring(0, 1) == "N")
                    {
                        Console.Clear();
                        Console.WriteLine("Fim");
                        break;
                    }
                    Console.Clear();
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static void Menu()
        {
            Console.Write("\n1. Adição \n2. Subtração \n3. Multiplicação \n4. Divisão \n\nDigite sua escolha: ");
        }

        private static bool ValidaMenu(out int numero)
        {
            return int.TryParse(Console.ReadLine(), out numero) && numero > 0 && numero <= 4;
        }

        private static bool ValidaNumero(out int numero)
        {
            return int.TryParse(Console.ReadLine(), out numero);
        }

        private static string Calculadora(int numeroDeEntrada, int primeiroNumero, int segundoNumero) 
        {
            if (numeroDeEntrada == 1) 
                return $"{Adicao(primeiroNumero, segundoNumero)}";
            else if (numeroDeEntrada == 2) 
                return $"{Subtracao(primeiroNumero, segundoNumero)}";
            else if (numeroDeEntrada == 3) 
                return $"{Multiplicacao(primeiroNumero, segundoNumero)}";
            else 
                return $"{Divisao(primeiroNumero, segundoNumero)}";
        }

        private static double Adicao(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        private static double Subtracao(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }

        private static double Multiplicacao(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }

        private static double Divisao(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }
    }
}
