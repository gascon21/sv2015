// Chen Chao
// 03/05/2016
#include <iostream>
using namespace std;

int main()
{
	int cases;
	cin >> cases;

	for (int i = 0; i < cases; i++)
	{
		int up[6], down[6];
		for (int j = 0; j < 6; j++)
			cin >> up[j];
		for (int j = 0; j < 6; j++)
			cin >> down[j];
		bool notValid = false;
		for (int j = 0; j < sizeof(up)/sizeof(int) - 1 && !notValid; j++)
		{
			if (up[j]+down[j] != up[j+1]+down[j+1])
				notValid = true;
		}
		
		if (!notValid)
			cout << "SI" << endl;
		else
			cout << "NO" << endl;
	}
	
	return 0;
}
