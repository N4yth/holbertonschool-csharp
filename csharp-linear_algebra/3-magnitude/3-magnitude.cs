using System;
using System.Collections.Generic;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Count == 2)
        {
            double a = vector[0] * vector[0];
            double b = vector[1] * vector[1];
            return Math.Sqrt(a + b);
        }
        else if (vector.Count == 3)
        {
            double a = vector[0] * vector[0];
            double b = vector[1] * vector[1];
            double c = vector[2] * vector[2];
            return Math.Sqrt(a + b + c);;
        }
        else
        {
            return -1;
        }
    }

}