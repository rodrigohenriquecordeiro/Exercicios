public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Gerador de números por extenso");
        GeraNumeroPorExtenso(ValidaNumero());
        Console.WriteLine("\nFim do programa");
    }

    private static int ValidaNumero()
    {
        try
        {
            Console.Write("\nDigite um número positivo: ");
            string? numero = Console.ReadLine();

            while (!int.TryParse(numero, out int erro) || numero is null || Convert.ToInt32(numero) < 0)
            {
                Console.WriteLine("Opção inválida, tente novamente!");
                Console.Write("\nDigite um número positivo: ");
                numero = Console.ReadLine();
            }

            return Convert.ToInt32(numero);
        }
        catch (Exception e)
        {
            throw new Exception($"Erro no número digitado: {e.Message}");
        }
    }

    private static void GeraNumeroPorExtenso(int numero)
    {
        if (numero.ToString().Length == 1)
        {
            Console.WriteLine($"{numero} = {Unidade(numero)}"); 
        }

        if (numero.ToString().Length == 2)
        {
            if (numero > 9 && numero < 21)
            {
                Console.WriteLine($"{numero} = {DezAVinte(numero)}");
            }

            if (numero > 20)
            {
                int dezena = int.Parse(numero.ToString().Substring(0, 1));
                int unidade = int.Parse(numero.ToString().Substring(1, 1));

                if (unidade == 0)
                    Console.WriteLine($"{numero} = {DemaisDezenas(dezena)}");
                else
                    Console.WriteLine($"{numero} = {DemaisDezenas(dezena)} e {Unidade(unidade)}");
            }
        }

        //if (numero.ToString().Length == 3)
        //{
        //    if (numero == 100)
        //        return "Cem";

        //    Centenas[] centena = (Centenas[])Enum.GetValues(typeof(Centenas));

        //    for (int i = 0; i < centena.Length; i++)
        //    {
        //        if (numero > 100 && numero < 120 && Convert.ToInt32(numero.ToString().Substring(2, 1)) == i)
        //            return $"{centena[i]}";

        //        if (numero > 120 && numero < 1000 && Convert.ToInt32(numero.ToString().Substring(2, 1)) == i)
        //            return $"{centena[i]}";
        //    }
        //}
    }

    private static string Unidade(int numero)
    {
        var resultado = numero switch
        {
            0 => "Zero",
            1 => "Um",
            2 => "Dois",
            3 => "Três",
            4 => "Quatro",
            5 => "Cinco",
            6 => "Seis",
            7 => "Sete",
            8 => "Oito",
            9 => "Nove",
            _ => "Inválido"
        };

        return resultado;
    }
    private static string DezAVinte(int numero)
    {
        var resultado = numero switch
        {
            10 => "Dez",
            11 => "Onze",
            12 => "Doze",
            13 => "Treze",
            14 => "Quatorze",
            15 => "Quinze",
            16 => "Dezesseis",
            17 => "Dezessete",
            18 => "Dezoite",
            19 => "Dezenove",
            20 => "Vinte",
            _ => "Inválido"
        };

        return resultado;
    }
    private static string DemaisDezenas(int numero)
    {
        var resultado = numero switch
        {
            2 => "Vinte",
            3 => "Trinta",
            4 => "Quarenta",
            5 => "Cinquenta",
            6 => "Sessenta",
            7 => "Setenta",
            8 => "Oitenta",
            9 => "Noventa",
            _ => "Inválido"
        };

        return resultado;
    }
}