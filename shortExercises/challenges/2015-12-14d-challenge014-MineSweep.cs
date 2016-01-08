// Chen Chao
// 14-12-2015

using System;

public class Challenge014
{
    public static void Main()
    {
        ushort cols, rows;
        string tableSize;
        
        do
        {
            tableSize = Console.ReadLine();
            string[] size = tableSize.Split(' ');
            cols = Convert.ToUInt16(size[0]);
            rows = Convert.ToUInt16(size[1]);
            ushort spacesFound = 0;
            
            if (cols != 0 && rows != 0)
            {
                string[,] mines = new string[rows,cols];
                
                for(ushort row = 0; row < rows; row++)
                {
                    string table = Console.ReadLine();
                    
                    for(ushort col = 0; col < cols; col++)
                        mines[row,col] = Convert.ToString(table[col]);
                }

                for (ushort row = 1; row < rows-1; row++)
                {
                    for (ushort col = 1; col < cols-1; col++)
                    {
                        ushort minesFound = 0;
                        
                        if (mines[row,col] != "*")
                        {
                            if (mines[row-1,col-1] == "*")
                                minesFound++;
                            if (mines[row-1,col] == "*")
                                minesFound++;
                            if (mines[row-1,col+1] == "*")
                                minesFound++;
                            if (mines[row,col-1] == "*")
                                minesFound++;
                            if (mines[row,col+1] == "*")
                                minesFound++;
                            if (mines[row+1,col-1] == "*")
                                minesFound++;
                            if (mines[row+1,col] == "*")
                                minesFound++;
                            if (mines[row+1,col+1] == "*")
                                minesFound++;
                            if (minesFound >= 6)
                                spacesFound++;
                        }
                    }
                }
                Console.WriteLine(spacesFound);
            }
        }
        while(cols != 0 && rows != 0);
        Console.WriteLine();
    }
}
