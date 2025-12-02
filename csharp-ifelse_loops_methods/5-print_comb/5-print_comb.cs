using System;

class Program
{
    static void Main(string[] args)
    {
        string separator = ", ";
        for (int i = 0 ; i <= 99 ; i++)
        {
            if (i < 99)
            {
                Console.Write($"{i.ToString("00")}{separator}");
            }
            else
            {
                Console.Write($"{i.ToString("00")}\n");
            }
        }
    }
}