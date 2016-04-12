// Chen Chao
// 11-04-2016

#include <iostream>
using namespace std;

int main()
{
    int cases;
    cin >> cases;
    
    for (int i = 0; i < cases; i++)
    {
        int n;
        int totalKm = 0;
        int tempKm = 0;
        do
        {
            cin >> n;
            
            if (n != 0)
            {
                tempKm += n;
                totalKm += (2 * tempKm);
            }
        }
        while (n != 0);
        cout << totalKm << endl;
    }
    return 0;
}
