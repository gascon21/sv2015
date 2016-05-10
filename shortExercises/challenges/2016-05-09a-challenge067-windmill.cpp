// Chen Chao
// 09-05-2016

#include <iostream>
using namespace std;

int main()
{
    int n;
    
    do
    {
        cin >> n;
        if (n != 0)
        {
            int energy[n];
            for (int i = 0; i < n; i++)
                cin >> energy[i];
            
            int cases;
            cin >> cases;
            for (int i = 0; i < cases; i++)
            {
                int min, max;
                cin >> min;
                cin >> max;
                int result = 0;
                for (int j = min - 1; j <= max - 1; j++)
                    result += energy[j];
                
                cout << result << endl;
            }
        }
    }
    while (n != 0);
    return 0;
}
