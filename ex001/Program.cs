// 1.	Faça um algoritmo que leia os valores A, B, C e diga se a soma de A + B é menor que C.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor para A: ");
        int valorA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite um valor para B: ");
        int valorB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite um valor para C: ");
        int valorC = Convert.ToInt32(Console.ReadLine());

        if (valorA + valorB < valorC)
        {
            Console.WriteLine("O valor da soma de A e B é menor que o valor de C.");
        }
    }
}
