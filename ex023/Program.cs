// 23.	Faça um algoritmo para ler três números e ordene-os em ordem decrescente.

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

        int maior,
            medio,
            menor;

        if (num1 >= num2 && num1 >= num3)
        {
            maior = num1;

            if (num2 >= num3)
            {
                medio = num2;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num2;
            }
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            maior = num2;

            if (num1 >= num3)
            {
                medio = num1;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num1;
            }
        }
        else
        {
            maior = num3;

            if (num1 >= num2)
            {
                medio = num1;
                menor = num2;
            }
            else
            {
                medio = num2;
                menor = num1;
            }
        }

        Console.WriteLine($"Os números em ordem decrescente são: {maior}, {medio} e {menor}.");
    }
}
