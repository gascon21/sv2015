#include <iostream>
using namespace std;


int main()
{
    int casos, diasComp, dia, mes, anyo;
    
    cin >> casos;
    int dias[casos];
    cin >> dia;
    cin >> mes;
    cin >> anyo;
    
    diasComp = (anyo * 360 + mes * 30 + dia);
    
    for (int i = 0; i < casos; i++)
    {
        cin >> dia;
        cin >> mes;
        cin >> anyo;
        dias[i] = (anyo * 360 + mes * 30 + dia);
    }
    
    for (int i = 0; i < casos; i++)
    {
        if (diasComp - dias[i] < 30)
            cout << "NOCNF" << endl;
        else if (diasComp - dias[i] >= 360)
            cout << "PRESIDENCIA" << endl;
        else
            cout << "CNF" << endl;
    }
    
    return 0;
}
