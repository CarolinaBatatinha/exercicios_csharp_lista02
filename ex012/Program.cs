// 12.	Faça um algoritmo para calcular o valor da conta de água, considerando a seguinte tabela de gastos:
// m³	            Cada m³
// 0 – 10	        R$ 1,20
// 11 – 20 	        R$ 1,50
// Acima de 20	    R$ 2,00

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de água consumida em metros cúbicos (m³): ");
        int consumo = Convert.ToInt32(Console.ReadLine());
        double valorM3;

        if (consumo <= 10)
        {
            valorM3 = 1.20;
        }
        else if (consumo <= 20)
        {
            valorM3 = 1.50;
        }
        else
        {
            valorM3 = 2.00;
        }

        double valorTotal = consumo * valorM3;

        Console.WriteLine($"Valor total da conta de água: R$ {valorTotal:F2}");
    }
}
