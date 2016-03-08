#include <iostream>
#include <string>

int main()
{
    int casos;
    std::cin >> casos;
    
    for (int i = 0; i < casos; i++)
    {
        int dia;
        int mes;
        std::cin >> dia;
        std::cin >> mes;
        
        if (dia == 25 && mes == 12 || dia % 2 == mes % 2)
            std::cout << "FESTIVO" << std::endl;
        else
            std::cout << "LABORABLE" << std::endl;
    }   
    
    return 0;
}
