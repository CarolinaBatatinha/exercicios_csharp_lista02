// 17.	O comerciante, ainda não satisfeito, solicitou a empresa de informática responsável pelos programas em sua loja, um programa que permite saber o lucro médio obtido quando acontece a compra por um cliente. Para isso, será necessário saber quantos produtos de cada tipo foi comprado pelo cliente, e fazer a média dos lucros em porcentagem.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de produtos tipo A comprados: ");
        int quantidadeA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de produtos tipo B comprados: ");
        int quantidadeB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de produtos tipo C comprados: ");
        int quantidadeC = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o valor de custo do produto tipo A: ");
        double custoA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor de venda do produto tipo A: ");
        double vendaA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor de custo do produto tipo B: ");
        double custoB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor de venda do produto tipo B: ");
        double vendaB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor de custo do produto tipo C: ");
        double custoC = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor de venda do produto tipo C: ");
        double vendaC = Convert.ToDouble(Console.ReadLine());

        double lucroA = ((vendaA - custoA) / custoA) * 100;
        double lucroB = ((vendaB - custoB) / custoB) * 100;
        double lucroC = ((vendaC - custoC) / custoC) * 100;

        double lucroMedio =
            ((lucroA * quantidadeA) + (lucroB * quantidadeB) + (lucroC * quantidadeC))
            / (quantidadeA + quantidadeB + quantidadeC);

        Console.WriteLine($"O lucro médio foi de {lucroMedio:F2}%.");
    }
}
