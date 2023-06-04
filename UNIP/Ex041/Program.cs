using System;

namespace Ex041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que dada a idade de um nadador, classifique-o em uma das seguintes categorias:
              - Infantil A = 5 a 7 anos
              - Infantil B = 8 a 11 anos
              - Juvenil A = 12 a 13 anos
              - Juvenil B = 14 a 17 anos
              - Adultos = Maiores de 18 anos*/

            try
            {
                Console.Write("Qual a idade do nadador? "); int idade = int.Parse(Console.ReadLine());
                Console.WriteLine(CalculaClassificacaoNadador(idade));
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string CalculaClassificacaoNadador(int idade)
        {
            return idade switch
            {
                var n when n > 5 && n <= 7 => "Infantil A",
                var n when n >= 8 && n <= 11 => "Infantil B",
                var n when n >= 12 && n <= 13 => "Juvenil A",
                var n when n >= 14 && n <= 17 => "Juvenil B",
                _ => "Adulto"
            };
        }
    }
}
