using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {

        double det = matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0];

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2 && det == 0)
        {
            return new double[,] {{ -1 }};
        }
        double[,] result = new double [2, 2];
        result[0,0] = Math.Round(matrix[1,1] / det, 2);
        result[0,1] = Math.Round(-matrix[0,1] / det, 2);
        result[1,0] = Math.Round(-matrix[1,0] / det, 2);
        result[1,1] = Math.Round(matrix[0,0] / det, 2);
        return result;
    }
}