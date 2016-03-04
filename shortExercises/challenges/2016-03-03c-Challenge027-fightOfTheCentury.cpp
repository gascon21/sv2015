// Chen Chao, Sacha, Miguel Moya

// Combate del siglo

/*
Ejemplo de entrada
3
2 100 100
1 4
A 1 10
A 1 5
R 10 30
R 10 30
2 4
A 1 10
A 1 5
R 10 30
R 10 30
2 100 100
1 4
A 1 10
A 1 5
R 10 30
R 10 30
2 2
A 1 1
R 1 1
2 100 100
1 4
A 1 100
A 1 50
R 10 30
R 10 30
2 2
A 11 10
A 11 10

Ejemplo de salida
ROQUE 2
EMPATE 2
APOLO 1
*/

#include <iostream>
using namespace std;

struct Boxeador
{
    string nombre;
    int vida;
    int golpes; 
};

int main()
{
    Boxeador box[2];
    box[0].nombre = "APOLO";
    box[1].nombre = "ROQUE";
    
    int casos, ronda;
    int rondaActual, golpes, vidaPropia, vidaEnemiga;
    char nomActual;
    string nomGanador;
    
    cin >> casos;
    
    for (int i = 0; i < casos; i++)
    {
        cin >> ronda;
        cin >> box[0].vida;
        cin >> box[1].vida;
        bool finalizado = false;
        bool empate = false;
        int rondaEmpate = 0;
        int rondaGanada = 0;
        
        for (int j = 0; j < ronda; j++)
        {
            cin >> rondaActual;
            cin >> golpes;
            
            for (int k = 0; k < golpes; k++)
            {
                cin >> nomActual;
                cin >> vidaPropia;
                cin >> vidaEnemiga;
                if (!finalizado && !empate)
                {
                    switch (nomActual)
                    {
                        case 'A':
                            box[0].vida -= vidaPropia;
                            box[1].vida -= vidaEnemiga;
                            box[0].golpes++;
                            if (box[1].vida <= 0)
                            {
                                nomGanador = box[0].nombre;
                                rondaGanada = (j + 1);
                                finalizado = true;
                            }
                            if (box[0].vida == 0 && box[1].vida == 0)
                            {
                                empate = true;
                                rondaEmpate = (j + 1);
                            }
                            break;
                        default:
                            box[1].vida -= vidaPropia;
                            box[0].vida -= vidaEnemiga;
                            box[1].golpes++;
                            if (box[0].vida <= 0)
                            {
                                nomGanador = box[1].nombre;
                                rondaGanada = (j + 1);
                                finalizado = true;
                            }
                            if (box[0].vida == 0 && box[1].vida == 0)
                            {
                                empate = true;
                                rondaEmpate = (j + 1);
                            }
                            break;
                    }
                }
            }
        }
        if (finalizado)
            cout << nomGanador << " " << rondaGanada << endl;
        else if (empate)
            cout << "EMPATE" << " " << rondaEmpate << endl;
        else if ((box[0].vida == 0 && box[1].vida == 0) 
                || ((box[0].golpes == box[1].golpes && box[0].vida != 0 && box[1].vida != 0)))
            cout << "EMPATE" << " " << ronda << endl;
        else if (box[0].golpes > box[1].golpes && box[0].vida != 0 && box[1].vida != 0)
            cout << box[0].nombre << " " << ronda << endl;
        else if (box[0].golpes < box[1].golpes && box[0].vida != 0 && box[1].vida != 0)
            cout << box[1].nombre << " " << ronda << endl;
    }
    
    return 0;
}
