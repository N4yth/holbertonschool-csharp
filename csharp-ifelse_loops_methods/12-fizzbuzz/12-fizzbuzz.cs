using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1 ; i < 101 ; i++)
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else{
                    Console.Write("Fizz");
                }       
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz");
            }
            else
            {
                Console.Write(i);
            }
            if (i < 100)
            {
                Console.Write(" ");
            }
        }
        Console.Write("");
    }
}