using System;
using System.Collections.Generic;

namespace Ex059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que solicite dois caracteres de A a Z ao usuário e imprima o número de caracteres existente
              entre eles. Assuma que o usuário digite os 2 caracteres em ordem alfabética. Caso não o estejam, emitir mensagem de erro.
              Exemplo: Digite 2 caracteres: j t O numero de caracteres entre eles é: 9*/

            try
            {
                Console.WriteLine("Digite duas letras");
                Console.Write("1ª letra: "); string primeiraLetra = Console.ReadLine().ToUpper();
                Console.Write("2ª letra: "); string segundaLetra = Console.ReadLine().ToUpper();

                List<string> alfabeto = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", 
                    "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

                int resultado = alfabeto.IndexOf(segundaLetra) - alfabeto.IndexOf(primeiraLetra);

                if (resultado < 0)
                    Console.WriteLine("\nERRO! Letras estão invertidas");
                else 
                    Console.WriteLine($"\nEntre {primeiraLetra} e {segundaLetra} temos {resultado - 1} caracteres.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
