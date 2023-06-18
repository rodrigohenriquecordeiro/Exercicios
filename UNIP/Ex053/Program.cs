using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ex053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Durante uma corrida de automóveis com N voltas de duração foram anotados para um piloto, na ordem, os
              tempos registrados em cada volta. Fazer um programa para ler os tempos das N voltas, calcular e imprimir:
              i. melhor tempo;
              ii. a volta em que o melhor tempo ocorreu;
              iii. tempo médio das N voltas;*/

            try
            {
                double tempo = 0;
                List<double> list = new List<double>();

                while (tempo != -1)
                {
                    Console.Write("Digite o tempo da volta: ");
                    list.Add(tempo = double.Parse(Console.ReadLine()));
                }

                Console.WriteLine($"\nMelhor tempo: {list.Where(x => x > 0).Min()}" +
                    $"\nVolta em que o tempo ocorreu: {list.IndexOf(list.Where(x => x > 0).Min()) + 1}" +
                    $"\nTempo médio: {list.Where(x => x > 0).Average():F2}");

                Console.WriteLine("Fim");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
