// Chen Chao
// Miguel Moya Ortega
// Sacha Van de Sijpe Bueno

// Alternate (shorter) version

#include <iostream>
using namespace std;

int main()
{
    int casos, alto, ancho;
    cin >> casos;
    
    for (int i = 0; i < casos; i++)
    {
        cin >> alto;
        cin >> ancho;
        
        bool right = false;
        cout << "Caso " << i + 1 << endl;
        for (int j = 0; j < alto; j++)
        {
            if (j % 2 == 0)
            {
                for (int k = 0; k < ancho; k++)
                    cout << "#";
                cout << endl;
                
                right = ! right;
            }
            else
            {
                if (! right)
                    cout << "#";
                for (int k = 0; k < ancho - 1; k++)
                    cout << ".";
                if (right)
                    cout << "#";
                cout << endl;
            }
        }
    }
    
    return 0;
}
