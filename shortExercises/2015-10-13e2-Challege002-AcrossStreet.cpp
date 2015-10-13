/* Juan Salinas Gómez
 * across the street
 * 12/10/2015
 */

#include <iostream>
using namespace std;

int main()
{
    int number;
    
    do
    {
        cin >> number;
        
        if (number != 0)
        {
            if(number % 2 == 0)
                cout << "DERECHA" << endl;
                
            else
                cout << "IZQUIERDA" << endl;
        }
    }
    while(number != 0);
    
    return 0;
}
