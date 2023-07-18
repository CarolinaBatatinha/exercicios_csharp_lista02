// 30.	 O Palmeiras deseja aumentar o salário de seus jogadores e comissão técnica para motivá-los na tentiva de subir para a primeira divisão. O ajuste salarial deve obedecer à seguinte tabela:

// Categoria	Salário Atual	Ação
// Equipe técnica	-	Aumento de 15%
// Jogadores	0 a R$ 9.000,00	Aumento de 20%
// 	9.001,00 a 13.000	Aumento de 10%
// 	13.001 a 18.000	Aumento de 5%
// 	acima de 18.000	Sem aumento

// Preparar um algoritmo para ler o nome e o salário atual de cada jogador ou técnico e imprimir seu nome, salário atual e salário reajustado.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe seu cargo (1 - Jogador/  2 - Equipe Técnica): ");
        int cargo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe seu salário atual em reais (R$): ");
        double salario = Convert.ToDouble(Console.ReadLine());

        double novoSalario = 0;

        if (cargo == 1 && salario <= 9000)
        {
            novoSalario = salario * 1.2;
        }
        else if (cargo == 1 && salario > 9001 && salario <= 13000)
        {
            novoSalario = salario * 1.1;
        }
        else if (cargo == 1 && salario > 13001 && salario <= 18000)
        {
            novoSalario = salario * 1.05;
        }
        else if (cargo == 1 && salario > 18000)
        {
            novoSalario = salario;
        }
        else if (cargo == 2)
        {
            novoSalario = salario * 1.15;
        }

        Console.WriteLine($"{nome}, seu novo salário valerá R$ {novoSalario:F2}.");
    }
}
