//Sergio Martínez Mira

using System;
using System.Collections;

public class Morse
{
    public static string CheckCode(char firstletter, string check)
    {
        Hashtable code = new Hashtable();
        
        code.Add('A', ".-");
        code.Add('B', "-...");
        code.Add('C', "-.-.");
        code.Add('D',"-..");
        code.Add('E',".");
        code.Add('F',"..-.");
        code.Add('G',"--.");
        code.Add('H', "....");
        code.Add('I',"..");
        code.Add('J',".---");
        code.Add('K',"-.-");
        code.Add('L',".-..");
        code.Add('M',"--");
        code.Add('N',"-.");
        code.Add('O',"---");
        code.Add('P',".--.");
        code.Add('Q',"--.-");
        code.Add('R',".-.");
        code.Add('S',"...");
        code.Add('T',"-");
        code.Add('U',"..-");
        code.Add('V',"...-");
        code.Add('W',".--");
        code.Add('X',"-..-");
        code.Add('Y',"-.--");
        code.Add('Z',"--..");
        
        if (check == (string)code[firstletter])
            return "OK";
        
        return "X";
    }
    
    public static void Main()
    {
        string line = "";
        string ToCheck = "";
        //~ string[] codes = {".-","-...","-.-.","-..",".","..-.","--."
            //~ ,"....","..",".---","-.-",".-..","--",".-","---",".--."
            //~ ,"--.-",".-.","...","-","..-","...-",".--","-..-","-.--"
            //~ ,"--.."};
        do
        {
            line = Console.ReadLine();
            if ((line != "") && (line != null))
            {
                line = line.ToUpper();
                foreach(char c in line)
                {
                    if(c == 'O')
                        ToCheck += "-";
                    else if(c == 'A' || c == 'E' || c == 'I' || c == 'U')
                        ToCheck += ".";
                }
                Console.WriteLine(CheckCode(line[0],ToCheck));
            }
            ToCheck = "";
        }
        while((line != "") && (line != null));
    }
}
