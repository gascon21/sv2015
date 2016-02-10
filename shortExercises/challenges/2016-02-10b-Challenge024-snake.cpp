// Chen Chao
// Miguel Moya Ortega
// Sacha Van de Sijpe Bueno

#include <iostream>
using namespace std;

int main()
{
	int casos;
	cin >> casos;
	int alto;
	int ancho;
	
	
	for	(int i = 0; i < casos; i++)
	{
		cin >> alto;
		cin >> ancho;
		int right = -1;
		cout << "Caso " << i + 1 << endl;
		for (int j = 0; j < alto; j++)
		{
			if (j % 2 == 0)
			{
				right = -right;
				
				for (int k = 0; k < ancho; k++)
				{	
					cout << "#";
				}
				cout << endl;
			}
			else
			{
				for (int k = 0; k < ancho; k++)
				{
					if (right == 1)
					{
						if (k == ancho - 1)
							cout << "#";
						else
							cout << ".";
					}
					else
					{
						if (k == 0)
							cout << "#";
						else
							cout << ".";
					}
				}
				cout << endl;
			}
		}
	}
	
	return 0;
}
