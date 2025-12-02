using System;

class Number
{
    public static bool PrintLastDigit(int number)
    {
        return Math.Abs(number % 10);
    }
}