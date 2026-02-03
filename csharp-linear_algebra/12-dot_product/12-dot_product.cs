using System;
using System.Collections.Generic;
using System.Linq;

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Count() == 2 && vector2.Count() == 2)
        {
            return Math.Round((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]), 2);
        }
        else if (vector1.Count() == 3 && vector2.Count() == 3)
        {
            return Math.Round((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]), 2);
        }
        else
        {
            return -1;
        }
    }
}