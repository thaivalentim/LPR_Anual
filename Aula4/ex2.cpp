//Criação: 21/03/2025
#include <iostream>

int main() {
    std::cout << "Insira um valor qualquer: " << std::endl;
    double A;
    std::cin >> A;

    if (A == static_cast<int>(A)) {
        std::cout << "Agora, insira outro valor qualquer: " << std::endl;
        double B;
        std::cin >> B;

        if (B == static_cast<int>(B)) {
            if (A != 0 && B != 0) {
                if (static_cast<int>(A) % static_cast<int>(B) == 0 || static_cast<int>(B) % static_cast<int>(A) == 0) {
                    std::cout << "Os numeros " << A << " e " << B << " sao multiplos." << std::endl;
                } else {
                    std::cout << "Os numeros " << A << " e " << B << " nao sao multiplos." << std::endl;
                }
            } else {
                std::cout << "Nao se pode verificar se dois numeros sao ou nao multiplos caso um deles ou ambos sejam iguais a zero. Insira valores diferentes" << std::endl;
            }
        } else {
            std::cout << "O numero " << B << " possui casas decimais. Reinicie o programa e insira outro que seja inteiro." << std::endl;
        }
    } else {
        std::cout << "O numero " << A << " possui casas decimais. Reinicie o programa e insira outro que seja inteiro." << std::endl;
    }

    return 0;
}
