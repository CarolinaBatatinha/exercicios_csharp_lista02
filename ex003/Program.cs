//3.	Repita o exercício anterior sabendo que os números são diferentes, qual é o maior e o menor dos números.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro valor inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 != num2)
        {
            Console.WriteLine("Os números digitados são diferentes.");
            if (num1 > num2)
            {
                Console.WriteLine($"O maior número é {num1}. \nO menor número é {num2}.");
            }
            else
            {
                Console.WriteLine($"O maior número é {num2}. \nO menor número é {num1}.");
            }
        }
        else
        {
            Console.WriteLine("Os números digitados são iguais.");
        }
    }
}
