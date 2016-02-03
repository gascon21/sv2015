// Challenge 009
/*
Se dice que un número es hyperpar cuando todos sus dígitos son pares. 
¿Sabes identificarlos?

Entrada
La entrada consta de una serie de casos de prueba. Cada uno está 
compuesto de una única línea con un número no negativo ni mayor que 
10^9.
Los casos de prueba terminan con un número negativo que no habrá que procesar.

Salida
Para cada caso de prueba se escribirá, en una línea independiente, "SI" 
si el número es hyperpar y "NO" si no lo es.

Entrada de ejemplo
2460
1234
2
-1

Salida de ejemplo
SI
NO
SI

https://www.aceptaelreto.com/problem/statement.php?id=165
*/

#include <iostream>
using namespace std;
 
int main() 
{
    string num;
    do
    {
        bool hyperpar = true;
        cin >> num;
        
        if(num[0] != '-')
        {
            for(unsigned int i = 0 ; i < num.length() ; i ++)
                if(num[i] % 2 != 0)
                    hyperpar = false;
            if(hyperpar)
                cout << "SI" << endl;
            else
                cout << "NO" << endl;
        }
    }
    while(num[0] != '-');

    return 0;
}
