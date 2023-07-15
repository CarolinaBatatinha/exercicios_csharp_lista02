// 19.	Dado três números digitados pelo usuário, e todos diferentes, imprima o menor número.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira o terceiro número: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 < num2 && num1 < num3)
        {
            Console.WriteLine($"O menor número digitado é {num1}.");
        }
        else if (num2 < num3 && num2 < num1)
        {
            Console.WriteLine($"O menor número digitado é {num2}.");
        }
        else
        {
            Console.WriteLine($"O menor número digitado é {num3}.");
        }
    }
}
