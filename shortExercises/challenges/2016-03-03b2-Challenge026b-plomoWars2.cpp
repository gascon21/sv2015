// Chen Chao, Sacha, Miguel Moya

/*
Se nos mostrará los soldaditos ordenados de mayor a menor, en base a su 
altura, anchura y peso, en ese orden de importancia. En caso de empate 
total, se ordenarán de menor a mayor número de identificación.

Ejemplo de entrada
7
1 100 100 100
2 80 100 10
3 80 10 90
4 80 10 40
5 80 44 33
9 80 44 33
6 1000 1 1

Ejemplo de salida
6 1000 1 1
1 100 100 100
2 80 100 10
5 80 44 33
9 80 44 33
3 80 10 90
4 80 10 40
*/

#include <iostream>
using namespace std;

struct Soldado
{
    int id;
    int altura;
    int anchura;
    int peso;
};

int main()
{
    int casos;
    cin >> casos;
    Soldado sold[casos];
    
    for (int i = 0; i < casos; i++)
    {
        cin >> sold[i].id;
        cin >> sold[i].altura;
        cin >> sold[i].anchura;
        cin >> sold[i].peso;
    }
    
    for (int i = 0; i < casos - 1; i++)
    {
        for (int j = i + 1; j < casos; j++)
        {
            if (sold[i].altura < sold[j].altura)
            {
                Soldado s = sold[i];
                sold[i] = sold[j];
                sold[j] = s;
            }
            if (sold[i].altura == sold[j].altura 
                && sold[i].anchura < sold[j].anchura)
            {
                Soldado s = sold[i];
                sold[i] = sold[j];
                sold[j] = s;
            }
            if (sold[i].altura == sold[j].altura 
                && sold[i].anchura == sold[j].anchura 
                && sold[i].peso < sold[j].peso)
            {
                Soldado s = sold[i];
                sold[i] = sold[j];
                sold[j] = s;
            }
            if (sold[i].altura == sold[j].altura
                && sold[i].anchura == sold[j].anchura 
                && sold[i].peso == sold[j].peso 
                && sold[i].id > sold[j].id)
            {
                Soldado s = sold[i];
                sold[i] = sold[j];
                sold[j] = s;
            }
        }
    }
    
    for (int i = 0; i < casos; i++)
        cout << sold[i].id << " " << sold[i].altura << " " 
            << sold[i].anchura << " " << sold[i].peso << endl;
    
    return 0;
}
