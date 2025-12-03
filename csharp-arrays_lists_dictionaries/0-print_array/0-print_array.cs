using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size >= 0)
        {
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {

                result[i] = i;
                Console.Write(i);
                if (i != size)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
            return result;
        }
        else
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

    }
}