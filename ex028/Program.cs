// 28.	Calcule a média aritmética de três valores A, B e C, escrevendo o valor e a mensagem apropriada:
// Média > 9  ► Aluno Excelente
// Média <= 9 e média > 8, ► Bom Aluno
// Média <= 8 e média > 7, ► Aluno Regular
// Média <= 7 e média > 6, ► Aluno Aprovado
// Média <= 6 e média > 5, ► Aluno de Exame
// Caso contrário, mostre a mensagem reprovado.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor de A:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor de B:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor de C:");
        double c = Convert.ToDouble(Console.ReadLine());

        double media = (a + b + c) / 3;

        Console.WriteLine($"Média: {media:F1}");

        if (media > 9)
        {
            Console.WriteLine("Aluno Excelente");
        }
        else if (media <= 9 && media > 8)
        {
            Console.WriteLine("Bom Aluno");
        }
        else if (media <= 8 && media > 7)
        {
            Console.WriteLine("Aluno Regular");
        }
        else if (media <= 7 && media > 6)
        {
            Console.WriteLine("Aluno Aprovado");
        }
        else if (media <= 6 && media > 5)
        {
            Console.WriteLine("Aluno de Exame");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}
