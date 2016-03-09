// Divisores del factorial
// (Aproximación, no terminado)

#include <iostream>
using namespace std;

int main()
{
    long long p, n;
    do
    {
        cin >> p;
        cin >> n;
        if (p >= 0 && n >= 0)
        {
            if (p == 0)
                cout << "NO" << endl;
            else if (p == 1 && n == 0)
                cout << "YES" << endl;
            else if (n == 0)
                cout << "NO" << endl;
            else if (n >= p)
                cout << "YES" << endl;
            else
            {
                bool canDivide = false;
                for (long long i = n - 1; i > 1 && !canDivide; i--)
                {
                    if (n % p == i)
                        canDivide = true;
                }
                if (canDivide)
                    cout << "YES" << endl;
                else
                    cout << "NO" << endl;
            }
        }
    }
    while(p >= 0 && n >= 0);
    
    return 0;
}
