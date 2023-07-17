// 24.	Faça um programa para ler 3 números reais e imprimi-los em ordem crescente. Se os números forem iguais, o cálculo o programa não deve ordená-los.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número real:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número real:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número real:");
        double num3 = Convert.ToDouble(Console.ReadLine());

        if (num1 != num2 && num1 != num3 && num2 != num3)
        {
            double menor,
                medio,
                maior;

            if (num1 < num2 && num1 < num3)
            {
                menor = num1;

                if (num2 < num3)
                {
                    medio = num2;
                    maior = num3;
                }
                else
                {
                    medio = num3;
                    maior = num2;
                }
            }
            else if (num2 < num1 && num2 < num3)
            {
                menor = num2;

                if (num1 < num3)
                {
                    medio = num1;
                    maior = num3;
                }
                else
                {
                    medio = num3;
                    maior = num1;
                }
            }
            else
            {
                menor = num3;

                if (num1 < num2)
                {
                    medio = num1;
                    maior = num2;
                }
                else
                {
                    medio = num2;
                    maior = num1;
                }
            }

            Console.WriteLine($"Os números em ordem crescente são: {menor}, {medio}, {maior}.");
        }
        else
        {
            Console.WriteLine("Existem números são iguais e não há necessidade de ordenação.");
        }
    }
}
