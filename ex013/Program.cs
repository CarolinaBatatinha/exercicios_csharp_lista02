//13.	Faça um algoritmo para calcular o valor da conta de energia elétrica de uma casa, considerando a tabela a seguir. A conta deve ser calculada proporcionalmente, ou seja, se o usuário gastou 55 KHW, ele pagará 50 KWH ao preço de R$ 1,00 e 5 ao preço de R$ 1,30.

// KWH         	Valor
// 0 – 50	        R$ 1,00
// 51 – 100 	    R$ 1,30
// 101 - 150	    R$ 1,60
// Acima de 150	    R$ 2.00

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de KWh consumidos: ");
        int consumoKwh = Convert.ToInt32(Console.ReadLine());

        double valorTotal = 0;

        if (consumoKwh <= 50)
        {
            valorTotal = consumoKwh * 1.00;
        }
        else if (consumoKwh <= 100)
        {
            int faixa1 = 50;
            int faixa2 = consumoKwh - faixa1;
            valorTotal = (faixa1 * 1.00) + (faixa2 * 1.30);
        }
        else if (consumoKwh <= 150)
        {
            int faixa1 = 50;
            int faixa2 = 50;
            int faixa3 = consumoKwh - faixa1 - faixa2;
            valorTotal = (faixa1 * 1.00) + (faixa2 * 1.30) + (faixa3 * 1.60);
        }
        else
        {
            int faixa1 = 50;
            int faixa2 = 50;
            int faixa3 = 50;
            int faixa4 = consumoKwh - faixa1 - faixa2 - faixa3;
            valorTotal = (faixa1 * 1.00) + (faixa2 * 1.30) + (faixa3 * 1.60) + (faixa4 * 2.00);
        }

        Console.WriteLine($"Valor total da conta de energia: R$ {valorTotal:F2}.");
    }
}
