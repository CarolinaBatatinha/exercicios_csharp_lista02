// 29.	Elaborar um programa que calcule a média ponderada de um aluno da disciplina de Algoritmo. Esta média tem pesos: 4 para a primeira prova e 3 para a segunda prova. Após calculada a média, uma mensagem deve ser apresentada informando a situação do aluno: APROVADO COM MÉDIA ou NECESSITA FAZER SUBSTITUTIVA. Caso o aluno necessite fazer prova substitutiva, o programa deve pedir esta nota e calcular a nova média do aluno. Uma nova mensagem da situação deve informar ALUNO COM MÉDIA ou ALUNO REPROVADO. Obs: A prova substitutiva pode substituir a primeira prova ou a segunda prova, portanto o programa deve verificar quando o aluno fica com maior média, isto é, quando a primeira prova é substituída pela prova substitutiva ou quando a segunda prova é substituída pela prova substitutiva.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a nota da primeira prova: ");
        double notaProva1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a nota da segunda prova: ");
        double notaProva2 = Convert.ToDouble(Console.ReadLine());

        double media = ((4 * notaProva1) + (3 * notaProva2)) / 7;

        Console.WriteLine($"Média: {media:F1}");

        if (media >= 6)
        {
            Console.WriteLine("APROVADO COM MÉDIA");
        }
        else
        {
            Console.WriteLine("NECESSITA FAZER SUBSTITUTIVA");

            Console.WriteLine("Informe a nota da prova substitutiva:");
            double notaSubstitutiva = Convert.ToDouble(Console.ReadLine());

            double novaMedia1 = ((4 * notaSubstitutiva) + (3 * notaProva2)) / 7;
            double novaMedia2 = ((4 * notaProva1) + (3 * notaSubstitutiva)) / 7;

            if (novaMedia1 > novaMedia2)
            {
                Console.WriteLine($"Média do aluno após prova substitutiva: {novaMedia1:F1}");

                if (novaMedia1 >= 6)
                {
                    Console.WriteLine("ALUNO APROVADO");
                }
                else
                {
                    Console.WriteLine("ALUNO REPROVADO");
                }
            }
            else
            {
                Console.WriteLine($"Média do aluno após prova substitutiva: {novaMedia2:F1}");

                if (novaMedia2 >= 6)
                {
                    Console.WriteLine("ALUNO APROVADO");
                }
                else
                {
                    Console.WriteLine("ALUNO REPROVADO");
                }
            }
        }
    }
}
