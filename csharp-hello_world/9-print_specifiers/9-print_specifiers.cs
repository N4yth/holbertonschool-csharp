using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine($"Percent: {percent*100}% \nCurrency: ${currency.ToString("###,##0.00")}");
	}
}