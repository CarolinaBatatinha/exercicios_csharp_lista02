//5.	Faça um algoritmo para imprimir a média e informar se o aluno foi aprovado ou reprovado e, qual a média obtida.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua primeira nota: ");
        decimal nota1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite sua segunda nota: ");
        decimal nota2 = Convert.ToDecimal(Console.ReadLine());
        decimal media = (nota1 + nota2) / 2;

        if (media >= 6)
        {
            Console.WriteLine("==================");
            Console.WriteLine("Você está aprovado.");
            Console.WriteLine($"Sua média foi {media}.");
            Console.WriteLine("==================");
        }
        else
        {
            Console.WriteLine("==================");
            Console.WriteLine("Você está reprovado.");
            Console.WriteLine($"Sua média foi {media}.");
            Console.WriteLine("==================");
        }
    }
}
