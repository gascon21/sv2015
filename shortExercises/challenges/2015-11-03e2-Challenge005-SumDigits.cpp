// Sum digits

/*
Input

3433
64323
8
-1

Output

3 + 4 + 3 + 3 = 13
6 + 4 + 3 + 2 + 3 = 18
8 = 8
*/

#include <iostream>
using namespace std;

int main()
{
    string number;
    
    do
    {            
        cin >> number;
        long sum = 0;
        if (number != "-1")
        {
            int size = number.length();
            cout << number[0];
            sum += number[0] - '0';
            for (int i = 1; i < size; i++)
            {
                cout << " + ";
                cout << number[i];
                sum += number[i] - '0';
            }
            cout << " = ";
            cout << sum << endl;
        }            
    }
    while (number != "-1");
    
    return 0;
}
