using System;
using System.Runtime.ConstrainedExecution;

namespace Ex040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de indústrias que são
              altamente poluentes do meio ambiente. O índice de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe
              para 0,3 as indústrias do 1º grupo são intimadas a suspenderem suas atividades, se o índice crescer para 0,4 as
              industrias do 1º e 2º grupo são intimadas a suspenderem suas atividades, se o índice atingir 0,5 todos os grupos
              devem ser notificados a paralisarem suas atividades. Faça um programa que leia o índice de poluição medido e
              emita a notificação adequada aos diferentes grupos de empresas. O algoritmo só deve parar de rodar quando o
              usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".*/

            try
            {
                while (true) 
                {
                    Console.WriteLine("Índice de Poluição");
                    Console.Write("Índice do Grupo 01: "); double indiceGrupo1 = double.Parse(Console.ReadLine());
                    Console.Write("Índice do Grupo 02: "); double indiceGrupo2 = double.Parse(Console.ReadLine());
                    Console.Write("Índice do Grupo 03: "); double indiceGrupo3 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\n{CalculaIndiceDePoluicao(indiceGrupo1, indiceGrupo2, indiceGrupo3)}");
                    Console.Write("\nDeseja encerrar o programa? "); string continuar = Console.ReadLine();
                    if (continuar.ToUpper() == "S")
                        break;
                }
                Console.WriteLine("Fim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string CalculaIndiceDePoluicao(double indiceGrupo1, double indiceGrupo2, double indiceGrupo3)
        {
            return $"Grupo 01: {Indice(indiceGrupo1)}" +
                $"\nGrupo 02: {Indice(indiceGrupo2)}" +
                $"\nGrupo 03: {Indice(indiceGrupo3)}";
        }

        private static string Indice(double indice)
        {
            if (indice >= 0.05 && indice <= 0.3)
                return "Suspender atividades do Grupo 01";
            else if (indice > 0.3 && indice <= 0.4)
                return "Suspender atividades do Grupo 01 e Grupo 02";
            else
                return "Suspender atividades de todos os Grupos";
        }
    }
}
