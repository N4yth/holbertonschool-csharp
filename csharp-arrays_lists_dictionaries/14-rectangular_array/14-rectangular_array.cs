using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0 ; i < 5 ; i++)
        {
            for (int y = 0 ; y < 5 ; y++)
            {
                if (i == 2 && y == 2)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
                if (y < 4)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
        }
    }
}