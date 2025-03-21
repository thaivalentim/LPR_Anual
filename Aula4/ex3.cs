//Criação: 21/03/2025
using System;

class RPGGame
{
    static int Main()
    {
        Console.WriteLine("Bem-vindo ao jogo de RPG!");
        Console.WriteLine("Para continuar jogando, escolha entre 3 classes de personagens: Guerreiro, Mago ou Arqueiro.");
        Console.WriteLine("Após sua escolha, as características e habilidades da classe escolhida serão exibidas.");

        string input = Console.ReadLine() ?? string.Empty;
        string classe = input != null ? input.Trim().ToLower() : string.Empty;

        ExibirInformacoesClasse(classe);

        return 0; 
    }

    static void ExibirInformacoesClasse(string classe)
    {
        if (classe == "guerreiro")
        {
            Console.WriteLine("Classe escolhida: Guerreiro");
            Console.WriteLine("Tipo de ataque: Pesado");
            Console.WriteLine("Nível de defesa: Total");
            Console.WriteLine("Outras informações sobre o guerreiro serão reveladas conforme você jogar!");
        }
        else if (classe == "mago")
        {
            Console.WriteLine("Classe escolhida: Mago");
            Console.WriteLine("Ataca por: Bola de Fogo");
            Console.WriteLine("Se defende por: Escudo de Gelo");
            Console.WriteLine("Outras informações sobre o mago serão reveladas conforme você jogar!");
        }
        else if (classe == "arqueiro")
        {
            Console.WriteLine("Classe escolhida: Arqueiro");
            Console.WriteLine("Ataca com: Flecha Precisa e Disparo Triplo");
            Console.WriteLine("Outras informações sobre o arqueiro serão reveladas conforme você jogar!");
        }
        else
        {
            Console.WriteLine("Classe inválida! Por favor, escolha entre Guerreiro, Mago ou Arqueiro.");
        }
    }
}
