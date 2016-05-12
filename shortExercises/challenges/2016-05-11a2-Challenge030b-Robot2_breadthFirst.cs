// Treasure, V2
// Breadth First Search, instead of depth-first search
#define debugging

using System;
using System.Collections.Generic;

public class TreasureSearch
{
    public static void Main()
    {
        string[] widthHeight = Console.ReadLine().Split();
        int width = Convert.ToInt32(widthHeight[0]);
        int height = Convert.ToInt32(widthHeight[1]);

        char[,] map = new char[width, height];
#if debugging
        for (int row = 0; row < height; row++)
            for (int col = 0; col < width; col++)
                map[col, row] = '.';
#endif

        string[] xyRobot = Console.ReadLine().Split();
        int xRobot = Convert.ToInt32(xyRobot[0]) - 1;
        int yRobot = Convert.ToInt32(xyRobot[1]) - 1;
        map[xRobot, yRobot] = 'R';

        string[] xyTreasure = Console.ReadLine().Split();
        int xTreasure = Convert.ToInt32(xyTreasure[0]) - 1;
        int yTreasure = Convert.ToInt32(xyTreasure[1]) - 1;
        map[xTreasure, yTreasure] = 'T';

        int obstaclesAmount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < obstaclesAmount; i++)
        {
            string[] xyObstacle = Console.ReadLine().Split();
            int xObstacle = Convert.ToInt32(xyObstacle[0]) - 1;
            int yObstacle = Convert.ToInt32(xyObstacle[1]) - 1;
            map[xObstacle, yObstacle] = 'X';
        }

        Queue<int> candidateCols = new Queue<int>();
        Queue<int> candidateRows = new Queue<int>();

        if (Reachable(map, width, height, 
                candidateCols, candidateRows, xRobot, yRobot))
            Console.WriteLine("TESORO");
        else
            Console.WriteLine("IMPOSIBLE");
    }

    public static void Display(char[,] map, int width, int height)
    {
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write(map[col, row]);
            }
            Console.WriteLine();
        }
    }

    public static bool Reachable(char[,] map,
        int width, int height, 
        Queue<int> candidateCols,
        Queue<int> candidateRows,
        int startX, int startY)
    {
#if debugging
        Console.WriteLine();
        Display(map, width, height);
#endif

        if (startX < 0) return false;
        if (startY < 0) return false;
        if (startX > width - 1) return false;
        if (startY > height - 1) return false;

        if (map[startX, startY] == 'X') return false;
        if (map[startX, startY] == 'T') return true;

        map[startX, startY] = 'X';
        candidateCols.Enqueue(startX+1); candidateRows.Enqueue(startY);
        candidateCols.Enqueue(startX-1); candidateRows.Enqueue(startY);
        candidateCols.Enqueue(startX); candidateRows.Enqueue(startY+1);
        candidateCols.Enqueue(startX); candidateRows.Enqueue(startY-1);

        while( candidateCols.Count > 0)
        {
            int nextX = candidateCols.Dequeue();
            int nextY = candidateRows.Dequeue();
            if (Reachable(map, width, height, 
                    candidateCols, candidateRows, nextX, nextY))
                return true;
        }
        return false;
    }
}
