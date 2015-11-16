//Adrian Navarro Garcia.
/*
We have been told that we can compute the MD5 Hash for an int number 
"x" using the following code:

using System.Security.Cryptography;
using System.Text;

MD5 md5Hash = MD5.Create();
byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(x.ToString()));
StringBuilder sBuilder = new StringBuilder();
for (int i = 0; i < data.Length; i++)
{
    sBuilder.Append(data[i].ToString("x2"));
}
string hash = sBuilder.ToString();

// See more details at:
// http://msdn.microsoft.com/es-es/library/system.security.cryptography.md5.aspx

Your task is to find a 5 digit number "x" which is encrypted as 
099ebea48ea9666a7da2177267983138
*/

using System.Security.Cryptography;
using System.Text;
public class Cracking
{
    public static void Main()
    {
        string hash="",
            md5toCrack="099ebea48ea9666a7da2177267983138";
        for (int x=10000;x<=99999;x++)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(
                Encoding.UTF8.GetBytes(x.ToString()));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            hash = sBuilder.ToString();
            if (hash==md5toCrack)
            {
                System.Console.WriteLine(hash);
                System.Console.WriteLine("The number X is {0}",x);
            }
        }
    }
}
