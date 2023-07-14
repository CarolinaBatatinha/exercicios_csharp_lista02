//14.	Uma empresa de modelo está contratando garotas para iniciar um trabalho de divulgação de produtos de beleza. Para isso, está selecionando garotas que tenham o seguinte perfil:

// a.	Idade superior a 18 anos
// b.	Cabelos Loiros
// c.	Altura superior a 1,75 m
// d.	Peso inferior a 60 kg
// e.	Seios: 85 a 87 cm
// f.	Cintura: 60 cm
// g.	Olhos verdes
// h.	Quadril = 60 cm

// Você foi escalado por sua empresa para elaborar um algoritmo que permite entrar com os valores referentes às características acima e, informar se a garota foi selecionada ou não.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a idade da garota: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Os cabelos são loiros? (Sim/Não): ");
        string cabelosLoiros = Console.ReadLine();

        Console.WriteLine("Informe a altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o peso em kg: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o tamanho do busto em cm: ");
        double seios = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a medida da cintura em cm: ");
        double cintura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Os olhos são verdes? (Sim/Não): ");
        string olhosVerdes = Console.ReadLine();

        Console.WriteLine("Informe a medida do quadril em cm: ");
        double quadril = Convert.ToDouble(Console.ReadLine());

        bool selecionada =
            idade > 18
            && cabelosLoiros.ToLower() == "sim"
            && altura > 1.75
            && peso < 60
            && seios >= 85
            && seios <= 87
            && cintura == 60
            && olhosVerdes.ToLower() == "sim"
            && quadril == 60;

        if (selecionada)
        {
            Console.WriteLine("Parabéns! A garota foi selecionada.");
        }
        else
        {
            Console.WriteLine("A garota não atende ao perfil requerido.");
        }
    }
}
