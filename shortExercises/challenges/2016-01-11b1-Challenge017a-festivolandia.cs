// Jorge Montalvo Blanes
// 

using System;

public class Challenge017
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        do
        {
            bool festiv = false;
            string numb = Console.ReadLine();
            string[]num = numb.Split(' ');
            int n1 = Convert.ToInt32(num[0]);
            int n2 = Convert.ToInt32(num[1]);
            if(n1== 25)
            {
                if(n2== 12)
                    festiv = true;
                else
                    festiv = false;
            }
            else if(n1%2==0)
            {
                if(n2%2==0)
                    festiv = true;
                else
                    festiv = false;
            }
            else
            {
                if(n2%2!=0)
                    festiv = true;
                else
                    festiv = false;
            }
            
            if(festiv)
                Console.WriteLine("FESTIVO");
            else
            {
                Console.WriteLine("LABORABLE");
            }
            
            cases--;
        }
        while(cases>0);
    }
}
