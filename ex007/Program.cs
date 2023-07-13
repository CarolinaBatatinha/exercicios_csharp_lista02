// 7.	Leia um número para verificar se ele é maior do que 20. Caso afirmativo imprima a metade desse número. Caso contrário imprima o seu quadrado.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num > 20)
        {
            Console.WriteLine(num / 2);
        }
        else
        {
            Console.WriteLine(Math.Pow(num, 2));
        }
    }
}