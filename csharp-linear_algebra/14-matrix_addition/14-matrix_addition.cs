using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Length == matrix2.Length && (matrix1.Length == 4 || matrix1.Length == 9))
        {
            double[,] result;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result.Add(matrix1[i, j] + matrix2[i, j]);
                }
            }
            return result;
        }
        else
        {
            double[,] result = {-1};
            return result;
        }
    }
}