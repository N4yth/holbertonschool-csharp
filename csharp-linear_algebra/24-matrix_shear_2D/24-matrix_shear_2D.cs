using System;
using System.Collections.Generic;
using System.Security.AccessControl;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if ((direction != 'y' && direction != 'x') || matrix.GetLength(1) != matrix.GetLength(0))
        {
            return new double[,] { { -1 } };
        }
        double[,] result = matrix.Clone() as double[,];

        if (direction == 'x')
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result[i, 0] = matrix[i, 0] + matrix[i, 1] * factor;
            }
        }
        else
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                result[0, i] = matrix[0, i] + matrix[1, i] * factor;
            }
        }
        return result;
    }
}