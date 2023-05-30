using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Ex033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova. O número de
              alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão.*/

            try
            {
                double nota = 0;
                List<double> notaDosAlunos = new List<double>();

                Console.Write("Nota da Prova: ");

                while (double.TryParse(Console.ReadLine(), out nota))
                {
                    if (notaDosAlunos.Count == 0)
                    {
                        notaDosAlunos.Add(nota);
                        Console.WriteLine($"1 aluno forma a média: {nota:F2}");
                        Console.Write("\nNota da Prova: ");
                    }
                    else
                    {
                        notaDosAlunos.Add(nota);
                        Console.WriteLine($"{notaDosAlunos.Count} alunos formam a média: {CalculaMedia(notaDosAlunos):F2}");
                        Console.Write("\nNota da Prova: ");
                    }
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            static double CalculaMedia(List<double> notaDosAlunos)
            {
                double media = 0;

                foreach (var item in notaDosAlunos)
                {
                    media += item;
                }

                return media /= notaDosAlunos.Count; ;
            }
        }
    }
}
