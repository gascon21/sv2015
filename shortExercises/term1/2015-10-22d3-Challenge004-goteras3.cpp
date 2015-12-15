// Goteras

#include <iostream>
using namespace std;

int main()
{
    long cases, drops;
    int hours, minutes, seconds;
    
    cin >> cases;
    
    for (long i = 0; i < cases; i++)
    {
        cin >> drops;
        
        hours = drops / 3600;
        seconds = drops % 3600;
        minutes = seconds / 60;
        seconds = seconds % 60;
        
        if (hours < 10)
            cout << "0";
        cout << hours;
        
        cout << ":";
        if (minutes < 10)
            cout << "0";
        cout << minutes;
        
        cout << ":";
        if (seconds < 10)
            cout << "0";
        cout << seconds << endl;
    }
    return 0;
}
