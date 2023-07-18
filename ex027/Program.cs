//  27.	Suponha que um caixa disponha apenas notas de 100, 10 e 1 Real. Considerando que alguém está pagando uma compra, faça um programa para determinar o número mínimo de notas que o caixa deve fornecer como troco. Imprima também o valor da compra, o valor do troco e a quantidade de cada tipo de nota a ser fornecido como troco. Suponha que o sistema monetário não utilize centavos.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor da compra:");
        int valorCompra = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o valor pago:");
        int valorPago = Convert.ToInt32(Console.ReadLine());

        int troco = valorPago - valorCompra;

        Console.WriteLine($"O valor da compra é de R$ {valorCompra:F2}.");
        Console.WriteLine($"O valor do troco foi de R$ {troco:F2}.");

        int notas100 = troco / 100;
        troco %= 100;

        int notas10 = troco / 10;
        troco %= 10;

        int notas1 = troco;

        Console.WriteLine("Quantidade de notas de R$ 100: " + notas100);
        Console.WriteLine("Quantidade de notas de R$ 10: " + notas10);
        Console.WriteLine("Quantidade de notas de R$ 1: " + notas1);
    }
}
