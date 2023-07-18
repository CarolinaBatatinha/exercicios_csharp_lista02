//  26.	Os salários dos empregados de uma empresa sofreram um aumento. Técnicos tiveram um aumento de 50%, gerentes de 30% e os demais de 10%. Faça um programa que calcule o salário reajustado para cada profissão.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a profissão do funcionário (Técnico, Gerente ou Outros):");
        string profissao = Console.ReadLine();

        Console.WriteLine("Informe o salário do funcionário:");
        double salario = Convert.ToDouble(Console.ReadLine());
        double percentualAumento;

        if (profissao.ToLower() == "técnico")
        {
            percentualAumento = 0.5;
        }
        else if (profissao.ToLower() == "gerente")
        {
            percentualAumento = 0.3;
        }
        else
        {
            percentualAumento = 0.1;
        }

        double aumento = salario * percentualAumento;
        double novoSalario = salario + aumento;

        Console.WriteLine($"O novo salário do funcionário vale R$ {novoSalario:F2}.");
    }
}
