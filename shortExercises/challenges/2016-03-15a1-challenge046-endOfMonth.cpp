// Chen Chao
// 15-03-2016

#include <iostream>
using namespace std;

int main()
{
    long long casos;
    cin >> casos;
    
    for (long long i = 0; i < casos; i++)
    {
        int n, n2;
        cin >> n;
        cin >> n2;
        
        if (n + n2 >= 0)
            cout << "SI" << endl;
        else
            cout << "NO" << endl;
    }
    return 0;
}
