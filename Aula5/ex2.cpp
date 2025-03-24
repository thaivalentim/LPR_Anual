#include <iostream>
#include <random>

int main() {
    std::random_device numAleatorio;
    std::uniform_int_distribution<> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAleatorio);

    int chute;
    int tentativas = 0;

    std::cout << "Tente adivinhar um numero disposto entre 1 e 100!" << std::endl;

    do {
        std::cout << "Digite seu chute: ";
        std::cin >> chute;
        tentativas++;

        if (chute > valorInteiro) {
            if (chute - valorInteiro <= 10) { 
                std::cout << "Seu chute esta acima do valor aleatorio! Mas esta quente!" << std::endl;
            } else {
                std::cout << "Seu chute esta acima do valor aleatorio! Mas esta frio!" << std::endl;
            }
        } else if (chute < valorInteiro) {
            if (valorInteiro - chute <= 10) { 
                std::cout << "Seu chute esta abaixo do valor aleatorio! Mas esta quente!" << std::endl;
            } else {
                std::cout << "Seu chute esta abaixo do valor aleatorio! Mas esta frio!" << std::endl;
            }
        } else {
            std::cout << "Voce acertou! O numero era " << valorInteiro << "." << std::endl;
            std::cout << "Voce precisou de " << tentativas << " tentativas para acertar." << std::endl;
        }
    } while (chute != valorInteiro);

    return 0;
}