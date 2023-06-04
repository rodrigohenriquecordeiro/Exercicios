using System;

namespace Ex038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um
              operário. E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a
              50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora
              excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. O
              programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
              programa?".*/

            try
            {
                while (true)
                {
                    Console.WriteLine("Cálculo de Horas Trabalhada");
                    Console.Write("Qual o código? "); int codigo = int.Parse(Console.ReadLine());
                    Console.Write("Quantas horas o funcionário trabalhou? "); decimal horasTrabalhadas = decimal.Parse(Console.ReadLine());
                    Console.WriteLine(CalculaSalario(codigo, horasTrabalhadas)); 

                    Console.Write("\nDeseja encerrar o programa? "); string encerrar = Console.ReadLine();
                    if (encerrar.ToUpper() == "S")
                        break;
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static string CalculaSalario(int codigo, decimal horasTrabalhada)
        {
            const decimal horaBase = 10;
            const decimal horaExcedente = 20;
            const int limitedeHoras = 50;
            decimal excessoDePagamento = 0;

            if (horasTrabalhada <= limitedeHoras)
            {
                return $"\nCódigo do Funcionário: {codigo}." +
                    $"\nSalário Excedente: {excessoDePagamento:C}." +
                    $"\nSalário Total: {horaBase * horasTrabalhada:C}.";
            }
            else
            {
                excessoDePagamento = (horasTrabalhada - limitedeHoras) * horaExcedente;
                return $"\nCódigo do Funcionário: {codigo}." +
                    $"\nSalário Excedente: {excessoDePagamento:C}." +
                    $"\nSalário Total: {horaBase * limitedeHoras + excessoDePagamento:C}.";
            }
        }
    }
}
