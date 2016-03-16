// Matriz identidad
// Chen Chao
// 16-03-2016

#include <iostream>
using namespace std;

int main()
{
    int size;
    do
    {
        cin >> size;
        if (size != 0)
        {

            bool invalid = false;
            int n;
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    cin >> n;

                    if (i == j && n != 1)
                        invalid = true;
                    else if (i != j && n != 0)
                        invalid = true;
                }
            }

            if (invalid)
                cout << "NO" << endl;
            else
                cout << "SI" << endl;
        }
    }
    while (size != 0);
    return 0;
}
