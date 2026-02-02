using System;
using System.Collections.Generic;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Count() == 2)
        {
            int a = vector[0] * vector[0];
            int b = vector[1] * vector[1];
            return Math.Sqrt(a + b);
        }
        else if (vector.Count() == 3)
        {
            int a = vector[0] * vector[0];
            int b = vector[1] * vector[1];
            int c = vector[2] * vector[2];
            return Math.Sqrt(a + b + c);;
        }
        else
        {
            return -1;
        }
    }

}