using System;

namespace Ex057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa que leia uma frase e imprima somente as vogais.*/

            try
            {
                Console.Write("Escreva uma frase: "); 
                string frase = Console.ReadLine();
                string letra = string.Empty;

                for (int i = 0; i < frase.Length; i++)
                {
                    letra = frase.ToUpper().Substring(i, 1);
                    if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
                        Console.Write(letra);
                    else
                        Console.Write("_");
                }
                
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
