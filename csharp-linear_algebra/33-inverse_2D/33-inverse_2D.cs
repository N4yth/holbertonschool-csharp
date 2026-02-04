using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {

        double det = matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0];

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2 || det == 0)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double [2, 2];

        result[0,0] =  matrix[1,1] / det;
        result[0,1] = -matrix[0,1] / det;
        result[1,0] = -matrix[1,0] / det;
        result[1,1] =  matrix[0,0] / det;

        return result;
    }
}