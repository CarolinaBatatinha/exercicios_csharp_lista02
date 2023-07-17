// 22.	Faça um algoritmo para ler três números e ordene-os em ordem crescente.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int menor,
            meio,
            maior;

        if (num1 <= num2 && num1 <= num3)
        {
            menor = num1;
            if (num2 <= num3)
            {
                meio = num2;
                maior = num3;
            }
            else
            {
                meio = num3;
                maior = num2;
            }
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            menor = num2;
            if (num1 <= num3)
            {
                meio = num1;
                maior = num3;
            }
            else
            {
                meio = num3;
                maior = num1;
            }
        }
        else
        {
            menor = num3;
            if (num1 <= num2)
            {
                meio = num1;
                maior = num2;
            }
            else
            {
                meio = num2;
                maior = num1;
            }
        }

        Console.WriteLine($"Os números em ordem crescente são:{menor}, {meio} e {maior}.");
    }
}
