// Gonzalo García Soler
// Challenge 60: Chess

#include <iostream>
using namespace std;

int main()
{
    bool finished = false;
    long long result = 0;

    do
    {
        long long nWheat = 0;
        long multiplier = 0;
        long slots = 0;
        
        cin >> nWheat;
        cin >> multiplier;
        cin >> slots;

        if (nWheat != 0 && multiplier != 0 && slots != 0)
        {
            result = 0;
            for (int i = 0; i < slots; i++)
            {
                result += nWheat;
                nWheat *= multiplier;
            }

            cout << result << endl;
        }
        else
            finished = true;
    }
    while (!finished);

    return 0;
}
