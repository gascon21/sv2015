#include <iostream>
#include <string>
using namespace std;

int main()
{
    int casos;
    cin >> casos;
    
    for (int i = 0; i < casos; i++)
    {
        int row, col;
        
        cin >> col;
        cin >> row;
        
        string text[row];
        bool NotValid = false;
        bool fFound = false;
        
        for (int j = 0; j < row; j++)
            cin >> text[j];
        
        for (int j = 0; j < row; j++)
            for (int k = 0; k < col; k++)
                if (text[j][k] == 'F')
                    fFound = true;
        
        for (int j = 1; j < row - 1; j++)
            for (int k = 1; k < col - 1; k++)
            {
                if (text[0][k] == 'F' || text[row-1][k] == 'F' ||
                        text[j][0] == 'F' || text[j][col-1] == 'F')
                    NotValid = true;
                else if (text[j][k] == 'F' && (text[j-1][k-1] == 'F' || 
                        text[j-1][k] == 'F' || text[j-1][k+1] == 'F'|| 
                        text[j][k-1] == 'F' || text[j][k+1] == 'F' || 
                        text[j+1][k-1] == 'F' || text[j+1][k] == 'F' || 
                        text[j+1][k+1] == 'F'))
                    NotValid = true;
            }
        if (! fFound)
            cout << "INVALIDA" << endl;
        else
        {
            if (NotValid)
                cout << "INVALIDA" << endl;
            else
                cout << "VALIDA" << endl;
        }
    }
    
    return 0;
}
