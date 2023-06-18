using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex051
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                /*Fazer um programa para ler uma quantidade N de alunos. Ler a nota de cada um dos N alunos e calcular a média
                  aritmética das notas. Contar quantos alunos estão com a nota acima de 7.0. Obs.: Se nenhum aluno tirou nota
                  acima de 5.0, imprimir mensagem: Não há nenhum aluno com nota acima de 5.*/

                List<double> lstNotas = new List<double>();

                Console.Write("Quantas notas serão cadastradas: "); int quantidadeDeNotas = int.Parse(Console.ReadLine());

                for (int i = 1; i <= quantidadeDeNotas; i++)
                {
                    Console.Write($"{i}º nota: "); double nota = double.Parse(Console.ReadLine());
                    lstNotas.Add(nota);
                }

                Console.WriteLine($"\nQuantidade de Notas: {quantidadeDeNotas}" +
                    $"\nMédia: {lstNotas.Sum() / quantidadeDeNotas}" +
                    $"\nTotal de Alunos com nota acima de 7: {lstNotas.Where(x => x >= 7).Count()}" +
                    $"\nTotal de Alunos com nota abaixo de 7: {lstNotas.Where(x => x < 5).Count()}");

                Console.WriteLine("\nFim");
                Console.ReadLine();
            }
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
        }
    }
}
