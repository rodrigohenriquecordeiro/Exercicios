using System;

namespace Ex061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que calcule e retorne o salário atualizado através do método REAJUSTE. O método deve
               receber o valor do salário e o índice de reajuste.*/

            try
            {
                Console.Write("Qual o valor do salário: R$ "); decimal salario = decimal.Parse(Console.ReadLine());
                Console.Write("Qual a porcentagem de reajuste? "); decimal valorDoReajuste = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"\nSalário {salario:C2} teve {valorDoReajuste}% ficando com {CalculaReajuste(salario, valorDoReajuste)}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            static string CalculaReajuste(decimal salario, decimal valorDoReajuste)
            {
                return (salario * (valorDoReajuste / 100 + 1)).ToString("C2") ;
            }
        }
    }
}
