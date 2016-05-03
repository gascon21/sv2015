using System;

class referencia
{
        
    public static void Main()
    {
        string line = "";

        do
        {
            line = Console.ReadLine().ToUpper();
            if (line != "")
            {
                string lineTemp = line.ToUpper();
                string representation = "";
                for (int i= 0;i<line.Length;i++)
                {
                    if ((line[i] == 'A') || (line[i] == 'E') ||
                        (line[i] == 'I') || (line[i] == 'U'))
                        representation += ".";
                    else if (line[i] == 'O')
                        representation += "-";
                }

                if (IsGoodReference(representation,line[0]))
                    Console.WriteLine(line + " OK");
                else
                    Console.WriteLine(line + " X");
            }
        } while (line != "");
    }

    public static bool IsGoodReference(string line,char character)
    {
        switch (character)
        {
            case 'A':
                return (line == ".-");
            case 'B':
                return (line == "-...");
            case 'C':
                return (line == "-.-.");
            case 'D':
                return (line == "-...");
            case 'E':
                return (line == ".");
            case 'F':
                return (line == "..-.");
            case 'G':
                return (line == "--.");
            case 'H':
                return (line == "-....");
            case 'I':
                return (line == "..");
            case 'J':
                return (line == ".---");
            case 'K':
                return (line == "-.-");
            case 'L':
                return (line == ".-..");
            case 'M':
                return (line == "--");
            case 'N':
                return (line == "-.");
            case 'O':
                return (line == "---");
            case 'P':
                return (line == ".--.");
            case 'Q':
                return (line == "--.-");
            case 'R':
                return (line == ".-.");
            case 'S':
                return (line == "...");
            case 'T':
                return (line == "-");
            case 'U':
                return (line == "..-");
            case 'V':
                return (line == "...-");
            case 'W':
                return (line == ".--");
            case 'X':
                return (line == "-..-");
            case 'Y':
                return (line == "-.--");
            case 'Z':
                return (line == "--..");
            default:
                return false;
        }
    }
        
}
