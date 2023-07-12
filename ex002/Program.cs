//2.	Faça um algoritmo para ler dois números é imprimir se eles são iguais, caso contrário, imprimir a mensagem: “os números são diferentes”.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro valor inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2)
        {
            Console.WriteLine("Os números digitados são iguais.");
        }
        else
        {
            Console.WriteLine("Os números digitados são diferentes.");
        }
    }
}
