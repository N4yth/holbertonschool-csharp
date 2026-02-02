using System;
using System.Collections.Generic;
using System.Linq;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Count() == 2)
        {
            double a = vector[0] * vector[0];
            double b = vector[1] * vector[1];
            return Math.Round(Math.Sqrt(a + b), 2);
        }
        else if (vector.Count() == 3)
        {
            double a = vector[0] * vector[0];
            double b = vector[1] * vector[1];
            double c = vector[2] * vector[2];
            return Math.Round(Math.Sqrt(a + b + c), 2);
        }
        else
        {
            return -1;
        }
    }

}