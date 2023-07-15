// 16.	Um comerciante está necessitando saber qual é o lucro de cada mercadoria vendida em sua loja. Para isso, está necessitando de um programa que permite informar o valor de custo e de venda de um produto, e imprima uma mensagem considerando a tabela a seguir:

// Lucro	            Mensagens
// Inferior a 10%	    “Baixo Lucro”
// Entre 10% e 20%	    “Lucro Médio”
// Acima de 20%	        “Lucro Alto”

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor de custo do produto: ");
        double custo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor de venda do produto: ");
        double venda = Convert.ToDouble(Console.ReadLine());

        double lucro = (venda - custo) / custo * 100;
        string mensagem;

        if (lucro < 10)
        {
            mensagem = "Baixo Lucro";
        }
        else if (lucro >= 10 && lucro <= 20)
        {
            mensagem = "Lucro Médio";
        }
        else
        {
            mensagem = "Lucro Alto";
        }

        Console.WriteLine($"Lucro: {lucro:F2}% - {mensagem}.");
    }
}
