// 9.	Faça um algoritmo para verificar se o ano é bissexto.

// ATENÇÃO!
// Para calcularmos se um ano é bissexto ou não, temos necessariamente que considerar os seguintes fatores: o ano deve ser divisível por quatro, o resto da divisão do ano por 100 tem que ser maior que zero ou a divisão do ano por 400 precisa ser igual a zero.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o ano a ser pesquisado: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        if ((ano % 4) == 0 || (ano % 100) > 0 || ((ano % 400) == 0))
        {
            Console.WriteLine($"{ano} é bissexto.");
        }
        else
        {
            Console.WriteLine($"{ano} não é bissexto.");
        }
    }
}
