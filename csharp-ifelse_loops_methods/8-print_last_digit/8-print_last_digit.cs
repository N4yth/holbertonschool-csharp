using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        return Math.Abs(number % 10);
    }
}