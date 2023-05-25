using System;

namespace Ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é igual a 1, igual a 2 ou
              igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o código e constatado que é
              um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou
              seja, apresentar a mensagem “um”, ”dois” ou “três”. (Utilizar o comando Switch).*/

            try
            {
                Console.Write("Digite um número inteiro: "); int codigo = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nResultado: {GeraNumeroPorExtenso(codigo)}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string GeraNumeroPorExtenso(int codigo)
        {
            switch (codigo)
            {
                case 1:
                    return "Um";
                case 2:
                    return "Dois";
                case 3:
                    return "Três";
                default:
                    return "Inválido";
            }
        }
    }
}
