using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número qualquer: ");
        int numero = int.Parse(Console.ReadLine());
        int quadrado = numero * numero;
        Console.WriteLine($"O quadrado de {numero} é {quadrado}");

        int somaDosDigitos = 0;
        while (quadrado > 0)
        {
            somaDosDigitos += quadrado % 10; 
            quadrado /= 10; 
        }
        
        Console.WriteLine($"A soma dos dígitos do quadrado é: {somaDosDigitos}");
    }
}