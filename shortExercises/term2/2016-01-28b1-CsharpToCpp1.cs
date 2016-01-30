//Vicente Cuenca


using System;
using System.IO;


class BasictoC
{
    static void Main()
    {
        Console.WriteLine("Enter the name of basic text: ");
        string name = Console.ReadLine();

        StreamReader myFile =
            File.OpenText(name);

        StreamWriter myNewFile =
            File.CreateText("pruebac++.txt");
            
        myNewFile.WriteLine("#include <iostream>");
        myNewFile.WriteLine("using namespace std;");
        myNewFile.WriteLine("int main()");
        myNewFile.WriteLine("  {");

        string sentence;

        do
        {

            sentence = myFile.ReadLine();



            if (sentence != null)
            {
                sentence = sentence.Trim(); 
                
                if((sentence.Contains("Console.Write"))&&!(sentence.Contains("Console.Write.Line")))
                {
                    sentence = sentence.Replace(";",""); //to avoid the semicolon appears
                    myNewFile.WriteLine("  count<<" +sentence.Substring(14)+";");
                }
                    
                if(sentence.Contains("Console.WriteLine"))
                {
                    sentence = sentence.Replace(";","");//to avoid the semicolon appears
                    myNewFile.WriteLine("  count>>" +sentence.Substring(17)+"<<endl;");
                }
                
                if (sentence.StartsWith("int") )
                {
                    sentence = sentence.Substring(3);
                    
                    myNewFile.WriteLine("  int<<" + sentence.Replace
                            ("= Convert.ToIn32(Console.ReadLine())",""));
                }
            }
        }
        while (sentence != null);

        myNewFile.WriteLine("  return o;");
        myNewFile.WriteLine("}");

        myFile.Close();
        myNewFile.Close();
    }
}
