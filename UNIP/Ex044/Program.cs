using System;

namespace Ex044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Calcular o IMC [mudei o exercício da lista para ser mais interessante]*/

            try
            {
                Console.WriteLine("***Cálculo de IMC***\n");

                double peso = 0;
                double altura = 0;
                string continuar = string.Empty;
                
                while (true)
                {
                    Console.Write("Digite o seu peso: ");
                    while (!double.TryParse(Console.ReadLine(), out peso))
                    {
                        Console.WriteLine("Dado inválido do peso, tente novamente!");
                        Console.Write("\nDigite o seu peso: ");
                    }

                    Console.Write("Digite a sua altura: ");
                    while (!double.TryParse(Console.ReadLine(), out altura))
                    {
                        Console.WriteLine("Dado inválido da altura, tente novamente!");
                        Console.Write("\nDigite a sua altura: ");
                    }
                    Console.WriteLine($"\nResultado : {GeraResultadoIMC(peso, altura)}");
                    
                    Console.Write("\nCalcular novamente? ");
                    continuar = Console.ReadLine();
                    Console.WriteLine();
                    if (continuar.ToUpper()[..] == "N")
                        break;
                }

                Console.WriteLine("Fim");
                Console.Read();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string GeraResultadoIMC(double peso, double altura)
        {
            double imc = double.Parse(CalculaIMC(peso, altura));

            if (imc < 17)
                return $"IMC: {imc}. Muito abaixo do peso"; 

            else if (imc >= 17 && imc <= 18.49)
                return $"IMC: {imc}. Abaixo do peso";

            else if (imc >= 18.5 && imc <= 24.99)
                return $"IMC: {imc}. Peso normal";

            else if (imc >= 25 && imc <= 29.99)
                return $"IMC: {imc}. Acima do peso";

            else if (imc >= 30 && imc <= 34.99)
                return $"IMC: {imc}. Obesidade I";

            else if (imc >= 35 && imc <= 39.99)
                return $"IMC: {imc}. Obesidade II (Severa)"; 

            else 
                return $"IMC: {imc}. Obesidade III (Mórbida)"; 
        }

        private static string CalculaIMC(double peso, double altura)
        {
            return (peso / (altura * altura)).ToString("F2");
        }
    }
}
