/* challenge06: invert sentence

Input 
3
this is a test
foobar
all your base

Output 
Case #1: test a is this
Case #2: foobar
Case #3: base your all

*/

#include <iostream>
#include <vector>
#include <sstream>
using namespace std;
 
int main()   
{
    int cases;
    cin >> cases;
    
    string sentence;
    getline(cin, sentence);  // To skip \n
    
    for (int i=0; i< cases; i++)
    {
        getline(cin, sentence);
        cout << "Case #" << i+1 << ":";
        
        // Now, let's imitate "Split"
        string part;
        stringstream myStream(sentence);
        vector<string> words;
        while (myStream >> part)
            words.push_back(part);
        
        // And finally let's display results
        for(int j= words.size()-1; j>=0; j--)
        {
            cout << " " << words[j];
        }
        cout << endl;
    }
}

