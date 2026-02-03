using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.Length == 2 || matrix.Length == 3)
        {
            double[,] result = new double[matrix.Length, matrix.Length];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i,j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }
        else
        {
            double[,] result = {{-1}};
            return result;
        }
    }
}