using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading.Tasks.Dataflow;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.GetLength(1) ==  0)
        {
            return new double[,] { {} };
        }
        double[,] result = new double[ matrix.GetLength(1),  matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                result[i, j] = matrix[j, i];
            }
        }
        return result;
    }
}