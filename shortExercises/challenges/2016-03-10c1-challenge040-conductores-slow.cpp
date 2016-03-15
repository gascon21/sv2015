// Chen Sacha Miguel

// Vehículos ecológicos

/*
Ejemplo de entrada
4
Alonso
0 0 0 1
Raik
0 0 0 2
Mas
0 0 0 3
Lentini
0 0 0 4

Ejemplo de salida
Lentini
Mas
Raik
Alonso

Ejemplo de entrada
2
Juan
0 0 2 2
Pedro
1 1 3 3

Ejemplo de salida
Juan
Pedro
*/

#include <iostream>
#include <cmath>
#include <ctime>
using namespace std;

struct Participante
{
    int posic;
    string nombre;
    int distancia;
};

int main()
{
    bool depurando = true;
    time_t instanteInicial, instanteFinal;
    instanteInicial = time(0);
    
    
    int cantidad;
    cin >> cantidad;
    Participante part[cantidad];
    int x1;
    int y1;
    int x2;
    int y2;
    for (int i = 0; i < cantidad; i++)
    {
        part[i].posic = i;
        cin >> part[i].nombre;
        cin >> x1;
        cin >> y1;
        cin >> x2;
        cin >> y2;
        double temp = sqrt((x2-x1)*(x2-x1)+ (y2-y1)*(y2-y1));
        part[i].distancia = trunc(temp);
    }

    for (int i = 0; i < cantidad - 1; i++)
    {
        for (int j = i + 1; j < cantidad; j++)
        {
            if ((part[i].distancia < part[j].distancia) 
                || (part[i].distancia == part[j].distancia 
                && part[i].posic > part[j].posic))
            {
                Participante tP = part[i];
                part[i] = part[j];
                part[j] = tP;
            }
        }
    }
    
    instanteFinal = time(0);
    
    for (int i = 0; i < cantidad; i++)
    {
        cout << part[i].nombre << endl;
    }
    
    if (depurando)
        cout << "Segundos empleados: "
            << instanteFinal - instanteInicial << endl;
    return 0;
}
