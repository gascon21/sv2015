#include <iostream>
#include <string>
using namespace std;

int main()
{
    string text, text2;
    int casos;
    cin >> casos;
    
    for (int i = 0; i < casos; i++)
    {
        cin >> text2;
        cin >> text;
        cin >> text2;
        
        if (text[1] == 'O')
            cout << "CIRCULO" << endl;
        else if (text[1] == 'X')
            cout << "CRUZ" << endl;
        else
            cout << "IMPOSIBLE" << endl;
    }
    
    return 0;
}
