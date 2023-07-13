// 8.	Leia um número e imprima se ele é positivo, negativo ou nulo.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine($"O número {num} é positivo.");
        }
        else if (num < 0)
        {
            Console.WriteLine($"O número {num} é negativo.");
        }
        else
        {
            Console.WriteLine($"O número {num} é nulo.");
        }
    }
}
