using System;

namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz
              12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.
              Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
              Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
              fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média,
              tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.*/

            try
            {
                Console.Write("Qual o tempo, em horas, gasto na viagem? "); double tempo = double.Parse(Console.ReadLine());
                Console.Write("Qual a velocidade média ocorrida? "); double velocidadeMedia = double.Parse(Console.ReadLine());
                Console.Write("Quantos livros de combustível foram utilizados? "); double combustivel = double.Parse(Console.ReadLine());

                double distancia = tempo * velocidadeMedia;
                double litrosUsados = distancia / 12;

                Console.WriteLine($"\nVelocidade Média: {velocidadeMedia} km/hora" +
                    $"\nTempo Gasto: {tempo} horas." +
                    $"\nDistância: {distancia} quilometros." +
                    $"\nQuantidade de Litros: {litrosUsados:F2}.");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
