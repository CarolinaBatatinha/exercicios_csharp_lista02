// 6.	Leia um número e imprima se ele é par ou impar.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"O número {num} é par.");
        }
        else
        {
            Console.WriteLine($"O número {num} é ímpar.");
        }
    }
}
