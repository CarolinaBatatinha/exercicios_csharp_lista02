//4.	Leia um número e, se ele for positivo, imprima seu inverso; caso contrário imprima seu quadrado Inverso. Inverso: 1/número.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro positivo ou negativo: ");
        float num = float.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine(1 / num);
        }
        else
        {
            Console.WriteLine((1 / num) * (1 / num));
        }
    }
}
