// // 11.	Faça um algoritmo para calcular, considerando que o usuário informe a idade (inteira), as seguintes informações sobre o usuário:
// a.	Número de semestres;
// b.	Número de meses;
// c.	Número de semanas;
// d.	Número de dias;
// e.	Número de horas;
// f.	Número de minutos;
// g.	Número de segundos;

// No final deseja-se visualizar todos os cálculos realizados e também se o usuário é infantil, adolescente, jovem ou adulto. A tabela abaixo demonstra as idades que defini essas categorias:

// Idade	        Categoria
// Até 12	        Infantil
// 13 a 16	        Adolescente
// 17 a 20	        Jovem
// 21a 50	        Adulto
// Acima de 50	    Idoso

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Número de semestres: {0}", idade / 6);
        Console.WriteLine("Número de meses: {0}", idade * 12);
        Console.WriteLine("Número de semanas: {0}", idade * 52);
        Console.WriteLine("Número de dias: {0}", idade * 365);
        Console.WriteLine("Número de horas: {0}", idade * 365 * 24);
        Console.WriteLine("Número de minutos: {0}", idade * 365 * 24 * 60);
        Console.WriteLine("Número de segundos: {0}", idade * 365 * 24 * 60 * 60);

        string categoria;
        if (idade <= 12)
        {
            categoria = "Infantil";
        }
        else if (idade >= 13 && idade <= 16)
        {
            categoria = "Adolescente";
        }
        else if (idade >= 17 && idade <= 20)
        {
            categoria = "Jovem";
        }
        else if (idade >= 21 && idade <= 50)
        {
            categoria = "Adulto";
        }
        else
        {
            categoria = "Idoso";
        }

        Console.WriteLine("Categoria: {0}", categoria);
    }
}
