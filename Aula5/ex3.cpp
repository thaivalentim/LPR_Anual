#include <iostream>

int main() {

    std::cout << "Este algoritmo se propoe a somar todos os numeros impares\n";
    std::cout << "e multiplos de 3 entre 50 e 500.\n\n";

    int soma = 0;

    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }

    std::cout << "A soma citada equivale a: " << soma << std::endl;

    return 0;
}