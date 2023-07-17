// 25.	Escreva um programa para calcular o reajuste salarial dos empregados de uma empresa, de acordo com os seguintes critérios:
// a.	Os funcionários com salário inferior a 1.000,00 devem ter um reajuste de 55%;
// b.	Funcionários com salário de 1.000,00 (inclusive) a 2.500,00 (inclusive) devem ter um reajuste de 33%;
// c.	Os funcionários com salário superior a 2.500,00 devem ter um reajuste de 20%;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o seu salário atual em reais (R$): ");
        double salario = Convert.ToDouble(Console.ReadLine());
        double novoSalario;

        if (salario < 1000)
        {
            novoSalario = salario * 1.55;
        }
        else if (salario >= 1000 && salario <= 2500)
        {
            novoSalario = salario * 1.33;
        }
        else
        {
            novoSalario = salario * 1.2;
        }

        Console.WriteLine($"Seu salário reajustado passará a valer R$ {novoSalario:F2}");
    }
}
