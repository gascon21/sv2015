// Challenge 59: Abdication of a king
// Chen Chao
// 07-04-2016

/*
Entrada de ejemplo
11
Felipe Carlos Felipe Felipe Felipe Carlos Felipe Carlos Alfonso Alfonso JuanCarlos
3
Felipe Leonor Felipe
12
Carlos Isabel Carlos Jorge Jorge Jorge Jorge Guillermo Victoria Jorge Jorge Isabel
3
Carlos Guillermo Jorge
0

Salida de ejemplo
6
1
7

3
2
7
*/

#include <iostream>
#include <vector>
using namespace std;

int getSuccessorNum(vector<string> names, string n)
{
    int repetitions = 0;
    for (int i = 0; i < names.size(); i++)
        if (n.compare(names[i]) == 0)
            repetitions++;
    
    return repetitions + 1;
}

int main()
{
    int cases;
    do
    {
        cin >> cases;
        if (cases != 0)
        {
            vector<string> names;
            
            for (int i = 0; i < cases; i++)
            {
                string n;
                cin >> n;
                names.push_back(n);
            }
            int successors;
            string name;
            cin >> successors;
            int successorNum[successors];
            for (int i = 0; i < successors; i++)
            {
                cin >> name;
                successorNum[i] = getSuccessorNum(names, name);
                names.push_back(name);
            }
            for (int i = 0; i < successors; i++)
                cout << successorNum[i] << endl;
        }
    }
    while (cases != 0);
    return 0;
}
