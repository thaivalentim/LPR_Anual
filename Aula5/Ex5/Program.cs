using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de horas de treinamento por dia: ");
        int horasPorDia = int.Parse(Console.ReadLine());

        int diasUteis = 5;
        int horasPorSemana = horasPorDia * diasUteis;

        Console.WriteLine($"\nTotal de horas de treinamento por semana: {horasPorSemana} horas");

        // Calcula o tempo necessário para alcançar 1000 horas usando um laço
        int totalHoras = 1000;
        int horasAcumuladas = 0;
        int semanasNecessarias = 0;

        while (horasAcumuladas < totalHoras)
        {
            horasAcumuladas += horasPorSemana;
            semanasNecessarias++;
        }

        int diasNecessarios = semanasNecessarias * diasUteis;
        double mesesNecessarios = semanasNecessarias / 4.5;

        // Exibe os resultados
        Console.WriteLine($"\nPara alcançar 1000 horas de treinamento:");
        Console.WriteLine($"- São necessários {diasNecessarios} dias úteis.");
        Console.WriteLine($"- São necessárias {semanasNecessarias} semanas.");
        Console.WriteLine($"- São necessários aproximadamente {mesesNecessarios:F1} meses.");
    }
}