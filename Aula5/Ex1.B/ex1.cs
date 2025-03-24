using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de números que serão digitados: ");
        int quantidade = int.Parse(Console.ReadLine());

        int somadosPares = 0;
        int contadordosPares = 0;
        int contador = 0;

        while (contador < quantidade)
        {
            Console.Write($"Digite o número {contador + 1}: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) // Verifica se o número é par
            {
                somadosPares += numero;
                contadordosPares++;
            }

            contador++;
        }

        if (contadordosPares > 0)
        {
            double media = (double)somadosPares / contadordosPares;
            Console.WriteLine($"A média dos números pares é: {media:F2}");
        }
        else
        {
            Console.WriteLine("Nenhum número par foi digitado.");
        }
    }
}