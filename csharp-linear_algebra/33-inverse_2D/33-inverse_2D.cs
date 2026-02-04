using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {

        double det = matrix[0, 0]*matrix[0, 1] - matrix[1, 0]*matrix[1, 1];

        if (matrix.Count() != 2 || det == 0)
        {
            return new double[,] { { -1 } };
        }

        double[] result = new double [2, 2];

        result[0, 0] = det/matrix[0, 0];
        result[1, 0] = det/matrix[1, 0];
        result[0, 1] = det/matrix[0, 1];
        result[1, 1] = det/matrix[1, 1];

        return result;
    }
}