using System;

namespace Ex046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses vetores. Ou seja, realizar
              a soma de todos dos resultados da multiplicação de x[i] por y[i].*/

            try
            {
                int[] x = { 2, 4, 6 }; 
                int[] y = { 1, 3, 5 }; 

                int n = x.Length; 

                int produtoEscalar = 0; 
                                
                for (int i = 0; i < n; i++)
                {
                    produtoEscalar += x[i] * y[i];
                }

                Console.WriteLine("O produto escalar é: " + produtoEscalar);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
