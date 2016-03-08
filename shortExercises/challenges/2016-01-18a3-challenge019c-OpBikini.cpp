#include <iostream>
using namespace std;

struct Paciente
{
    int w;
    int h;
};

int main()
{
    short casos;
    cin >> casos;
    Paciente paciente[casos];
    
    for (short i = 0; i < casos; i++)
    {
        cin >> paciente[i].w;
        cin >> paciente[i].h;
    }
    
    for (short i = 0; i < casos - 1; i++)
    {
        for (short j = i +1; j < casos; j++)
            if (paciente[i].w < paciente[j].w ||
                    (paciente[i].w == paciente[j].w  && 
                    paciente[i].h >= paciente[j].h))
            {
                Paciente tempPaciente = paciente[i];
                paciente[i] = paciente[j];
                paciente[j] = tempPaciente;
            }
    }
    
    for (short i = 0; i < casos; i++)
        cout << paciente[i].w << " " << paciente[i].h << endl;
    
    return 0;
}
