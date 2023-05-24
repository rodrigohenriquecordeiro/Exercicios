using System;

namespace Ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi
              aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota
              do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7,
              apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado,
              apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do
              aluno.*/

            try
            {
                Console.WriteLine("Cálculo da Média Final do Aluno");
                Console.Write("1ª nota: "); double n1 = double.Parse(Console.ReadLine());
                Console.Write("2ª nota: "); double n2 = double.Parse(Console.ReadLine());
                Console.Write("3ª nota: "); double n3 = double.Parse(Console.ReadLine());
                Console.Write("4ª nota: "); double n4 = double.Parse(Console.ReadLine());

                double media = CalculaMedia(n1, n2, n3, n4);
                Console.WriteLine($"\nMédia com 4 notas: {media:F2}");

                if (media >= 7)
                    Console.WriteLine("\nSTATUS: Aprovado");
                else
                {
                    Console.Write("\nQual a nota da prova de recuperação? "); double recuperacao = double.Parse(Console.ReadLine());
                    double mediaFinal = CalculaMedia(media, recuperacao);

                    if (mediaFinal >= 7)
                    {
                        Console.WriteLine($"\nSua Média Final com Prova de Recuperação foi {mediaFinal:F2}");
                        Console.WriteLine("\nSTATUS: Aprovado na Recuperação");
                    }
                    else
                    {
                        Console.WriteLine($"\nSua Média Final com Prova de Recuperação foi {mediaFinal:F2}");
                        Console.WriteLine($"\nSTATUS: Reprovado");
                    }
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static double CalculaMedia(params double[] notas)
        {
            double notasSomadas = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                notasSomadas += notas[i];
            }

            return notasSomadas / notas.Length;
        }


    }
}
