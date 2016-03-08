// Descending sum
// 123 -> 123 + 23 + 3 = 149
// Chao Chen

#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

int main()
{
    string text;
    do
    {
        cin >> text;
        long sum = 0;
        
        if (text != "0")
        {
            for (long i = 0; i < text.length(); i++)
            {
                sum += atol(text.substr(text.length()-(i+1),i+1).c_str());
            }
            cout << sum << endl;
        }
    }while (text != "0");
    
    return 0;
}
