// Challenge 049: The buffer
// Miguel Moya

#include <iostream>
using namespace std;

int main()
{
    long long trys;
    cin >> trys;
    for(long long i = 0; i < trys; i++)
    {
        long long persons;
        cin >> persons;
        if(persons % 2 == 0)
            cout << persons / 2 << endl;
        else
            cout << persons /2 + 1 << endl;
    }
    return 0;
}
