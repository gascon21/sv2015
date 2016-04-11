// Challenge 60: Chess
// C version

#include <stdio.h>

int main()
{
    bool finished = 0;
    long long result = 0;

    do
    {
        long long nWheat = 0;
        long multiplier = 0;
        long slots = 0;
        
        scanf("%lld", &nWheat);
        scanf("%lld", &multiplier);
        scanf("%lld", &slots);

        if (nWheat != 0 && multiplier != 0 && slots != 0)
        {
            result = 0;
            for (int i = 0; i < slots; i++)
            {
                result += nWheat;
                nWheat *= multiplier;
            }

            printf("%lld\n",result);
        }
        else
            finished = 1;
    }
    while (!finished);

    return 0;
}
