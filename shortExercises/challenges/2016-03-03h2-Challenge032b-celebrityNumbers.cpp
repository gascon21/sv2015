// Chen Chao, Sacha, Miguel Moya

#include <iostream>
using namespace std;

int main()
{
    int casos;
    cin >> casos;
    
    for (int i = 0; i < casos; i++)
    {
        int num;
        cin >> num;
        string n[num];
        int sum[num];
        
        for (int j = 0; j < num; j++)
        {
            cin >> n[j];
            sum[j] = 0;
            for (int k = 0; k < n[j].length(); k++)
                sum[j] += n[j][k] - '0';
        }
        
        int max = sum[0];
        int min = sum[0];
        
        for (int j = 0; j < num; j++)
        {
            max = max < sum[j] ? sum[j] : max;
            min = min > sum[j] ? sum[j] : min;
        }
        
        int cel = 0;
        int imp = 0;
        
        for (int j = 0; j < num; j++)
        {
            cel += sum[j] == max ? 1 : 0;
            imp += sum[j] == min ? 1 : 0;
        }
        cout << cel << " " << num - cel - imp << " " << imp << endl;
    }
    return 0;
}
