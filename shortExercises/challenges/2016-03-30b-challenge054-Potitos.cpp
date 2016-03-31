// Chen Chao
// 30-03-2016
// Challenge 054: Potitos
// https://www.aceptaelreto.com/problem/statement.php?id=185

#include <iostream>
#include <string>
#include <vector>
using namespace std;

int main()
{
    int cases;
    
    do
    {
        cin >> cases;
        if (cases != 0)
        {
            vector<string> si;
            vector<string> no;
            for (int i = 0; i < cases; i++)
            {
                string t;
                cin >> t;
                string ing;
                
                if (t == "SI:")
                {
                    do
                    {
                        cin >> ing;
                        if (ing != "FIN")
                            si.push_back(ing);
                    }
                    while (ing != "FIN");
                }   
                else if (t == "NO:")
                {
                    do
                    {
                        cin >> ing;
                        if (ing != "FIN")
                            no.push_back(ing);
                    }
                    while (ing != "FIN");
                }
            }
            for (int i = 0; i < si.size(); i++)
                for (int j = 0; j < no.size(); j++)
                 if (si[i] == no[j])
                    no[j] = "0";
            
            for (int i = 0; i < no.size() - 1; i++)
                for (int j = i + 1; j < no.size(); j++)
                    if (no[i].compare(no[j]) > 0)
                    {
                        string n = no[i];
                        no[i] = no[j];
                        no[j] = n;
                    }
            
            for (int i = 0; i < no.size(); i++)
                if (i < no.size() - 1 && no[i] != "0")
                    cout << no[i] << " ";
                else if (no[i] != "0")
                    cout << no[i];
            cout << endl;
            si.clear();
            no.clear();
        }
    }
    while (cases != 0);
    
    return 0;
}
