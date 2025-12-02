using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int result = Math.Abs(number % 10);
        Console.Write(result);
        return result;
    }
}