//15.	Desenvolva um algoritmo para calcular quantos reais serão necessários para encher o tanque de um veiculo para se realizar uma viagem. O usuário deverá informar o tipo de combustível do veículo, o número total de km a ser percorrido e o consumo médio do veículo. A tabela de preços dos combustíveis utilizada no cálculo é apresentada abaixo:

// Combustível	    Preço
// Gasolina	        22.25
// Álcool	        11.50
// Diesel	        11.65

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o tipo de combustível: (Gasolina/Álcool/Diesel): ");
        string tipoCombustivel = Console.ReadLine();

        Console.WriteLine("Informe a distância a ser percorrida em km: ");
        int distanciaKm = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o consumo médio do veículo (km/L): ");
        double consumoMedio = Convert.ToDouble(Console.ReadLine());

        double precoCombustivel;

        switch (tipoCombustivel.ToLower())
        {
            case "gasolina":
                precoCombustivel = 22.25;
                break;
            case "alcool":
                precoCombustivel = 11.5;
                break;
            case "diesel":
                precoCombustivel = 11.65;
                break;
            default:
                Console.WriteLine("Tipo de combustível inválido.");
                return;
        }

        double litrosNecessarios = distanciaKm / consumoMedio;
        double valorTotal = litrosNecessarios * precoCombustivel;

        Console.WriteLine($"Valor necessário para encher o tanque: R$ {valorTotal:F2}.");
    }
}
