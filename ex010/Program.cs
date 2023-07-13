// 10.	Faça um algoritmo para calcular a conta de energia elétrica de uma casa. O valor de cada KWH é R$1.50. Quando a casa é de uma aposentada, a conta tem um desconto de 15%.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o consumo de energia da casa: ");
        double consumoEnergia = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a idade do titular da conta: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        double valorKwh = 1.5;
        double valorConta = consumoEnergia * valorKwh;

        if (idade < 60)
        {
            Console.WriteLine($"O valor a ser pago é de R$ {valorConta:F2}");
        }
        else
        {
            double valorAposentado = valorConta - (valorConta * 0.15);
            Console.WriteLine($"O valor a ser pago é de R$ {valorAposentado:F2}");
        }
    }
}
