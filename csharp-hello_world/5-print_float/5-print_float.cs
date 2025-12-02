using System;

class Program
{
	static void Main(string[] args)
        {
            float number = 3.145546f;
            Console.WriteLine($"Float: {Math.Round(number,2).ToString("0.00")}");
        }
}