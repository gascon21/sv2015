// Miguel Moya Ortega y Carla Liarte

#include <iostream>
using namespace std;

int main()
{
    int cases;
    cin >> cases;
    
    for (int i = 0; i < cases; i++)
    {
        int totalNumbers;
        cin >> totalNumbers;
        int total = 0;
        
        for (int j = 0; j < totalNumbers; j++)
        {
            int number;
            cin >> number;
            if (number % 2 == 0)
                total++;
        }
        cout << total << endl;
    }
    return 0;
}
