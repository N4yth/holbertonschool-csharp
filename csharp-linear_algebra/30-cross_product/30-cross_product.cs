using System;
using System.Collections.Generic;
using System.Linq;

class MatrixMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Count() != 3 || vector2.Count() != 3)
        {
            return new double[]{-1};
        }
        return new double[] {
            vector1[2]*vector2[3] - vector1[3]*vector2[2],
            vector1[3]*vector2[1] - vector1[1]*vector2[3],
            vector1[1]*vector2[2] - vector1[2]*vector2[1]
            };
    }
}