#include <iostream>
#include <string>
using namespace std;

int main()
{
    long casos;
    cin >> casos;
    
    for (long i = 0; i < casos; i++)
    {
        string text;
        cin >> text;
        bool aFound = false;
        bool eFound = false;
        bool iFound = false;
        bool oFound = false;
        bool uFound = false;
        
        for (unsigned int j = 0; j < text.length(); j++)
        {
            if ((text[j] == 'a') || (text[j] == 'A'))
                aFound = true;
            if ((text[j] == 'e') || (text[j] == 'E'))
                eFound = true;
            if ((text[j] == 'i') || (text[j] == 'I'))
                iFound = true;
            if ((text[j] == 'o') || (text[j] == 'O'))
                oFound = true;
            if ((text[j] == 'u') || (text[j] == 'U'))
                uFound = true;
        }
        
        if (aFound && eFound && iFound && oFound && uFound)
            cout << "SI" << endl;
        else
            cout << "NO" << endl;
    }
    
    return 0;
}
