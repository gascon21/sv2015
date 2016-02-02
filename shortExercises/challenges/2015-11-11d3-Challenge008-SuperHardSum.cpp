// Super hard sum

/*
Your amazing program should calculate the sum if the numbers given in 
each line, and output on line for each question with the response. 
Numbers can be negative, really big and lines contain extra spaces, so 
make your program resistant to input.

Your program will need to read from standard input, line by line till 
the end of the input. Consider each line a different question. For each 
line you read, output the sum of all the given numbers.

Sample input and output

Sample input
123456789012 1
2 3
4   5 -1

Sample output
123456789013
5
8

Procedencia:
Concurso Tuenti 2011, pregunta 1
*/


#include <iostream>
#include <vector>   // for "vector"
#include <sstream>  // for "stringstream"
#include <cstdlib>  // for "atol"
using namespace std;

int main()
{
    string line;
    while (getline(cin, line))
    {
         // Now, let's imitate "Split"
        string part;
        stringstream myStream(line);
        vector<string> words;
        while (myStream >> part)
            words.push_back(part);
            
        // And finally sum the numbers
        long sum = 0;
        for(unsigned int i= 0; i < words.size(); i++)
        {
            sum += atol(words[i].c_str());
        }
        cout << sum << endl;
    }
        
    return 0;
}
