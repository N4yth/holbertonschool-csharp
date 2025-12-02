using System;

class Program
{
    static void Main(string[] args)
    {
        string separator = ", ";
        for (int i = 0 ; i <= 9 ; i++)
        {
            for (int y = i + 1 ; y <= 9 ; y++)
            {
                if (i != 8)
                {
                    Console.Write($"{i}{y}{separator}");
                }
                else
                {
                    Console.Write($"{i}{y}\n");
                }     
            }
        }
    }
}