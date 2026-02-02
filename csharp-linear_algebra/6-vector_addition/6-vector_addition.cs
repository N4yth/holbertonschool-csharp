using System;
using System.Collections.Generic;
using System.Linq;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Count() == 2 && vector2.Count() == 2)
        {
            double[] result = {vector1[0] + vector2[0], vector1[1] + vector2[1]};
            return result;
        }
        else if (vector1.Count() == 3 && vector2.Count() == 3)
        {
            double[] result = {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]};
            return result;
        }
        else
        {
            return -1;
        }
    }
}