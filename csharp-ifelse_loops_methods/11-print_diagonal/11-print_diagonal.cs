using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            for (int i = 0 ; i < length ; i++)
            {
                for (int Y = 0 ; Y < i ; Y++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\"); 
            }
        }
        Console.WriteLine("");
    }
}