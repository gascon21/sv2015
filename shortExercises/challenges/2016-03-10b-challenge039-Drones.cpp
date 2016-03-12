// Chen Sacha Miguel
// Problema B: Don Dron

#include <iostream>
using namespace std;

struct Dron
{
    int d;
    int x;
    int y;
    int a;
    int b;
};

int main()
{
    int n;
    cin >> n;
    Dron dr[n];
    for (int i = 0; i < n; i++)
    {
        cin >> dr[i].d;
        cin >> dr[i].x;
        cin >> dr[i].y;
        cin >> dr[i].a;
        cin >> dr[i].b;
    }
    bool inValid = false;
    for (int i = 0; i < n - 1 && !inValid; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (dr[i].d != dr[j].d && dr[i].x == dr[j].x && dr[i].y == dr[j].y
                    && dr[i].a >= dr[j].a && dr[i].a <= dr[j].b)
                inValid = true;
            if (dr[i].d != dr[j].d && dr[i].x == dr[j].x && dr[i].y == dr[j].y
                    && dr[i].b >= dr[j].a && dr[i].b <= dr[j].b)
                inValid = true;
            if (dr[i].d != dr[j].d && dr[i].x == dr[j].x && dr[i].y == dr[j].y
                    && dr[j].a >= dr[i].a && dr[j].a <= dr[i].b)
                inValid = true;
            if (dr[i].d != dr[j].d && dr[i].x == dr[j].x && dr[i].y == dr[j].y
                    && dr[j].b >= dr[i].a && dr[j].b <= dr[i].b)
                inValid = true;
        }
    }
    if (inValid)
        cout << "ERROR" << endl;
    else
        cout << "OK" << endl;
    
    return 0;
}
