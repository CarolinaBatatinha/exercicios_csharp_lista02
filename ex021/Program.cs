// 21.	Faça um algoritmo para determinar o maior e o menor de quatro números lidos.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número:");
        int numero3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o quarto número:");
        int numero4 = Convert.ToInt32(Console.ReadLine());

        int maior = numero1;
        int menor = numero1;

        if (numero2 > maior)
            maior = numero2;
        else if (numero2 < menor)
            menor = numero2;

        if (numero3 > maior)
            maior = numero3;
        else if (numero3 < menor)
            menor = numero3;

        if (numero4 > maior)
            maior = numero4;
        else if (numero4 < menor)
            menor = numero4;

        Console.WriteLine($"O menor número é {menor}.");
        Console.WriteLine($"O maior número é {maior}.");
    }
}
