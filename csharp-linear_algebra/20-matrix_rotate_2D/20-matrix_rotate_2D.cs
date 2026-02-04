using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != 2)
        {
            return new double[,] { { -1 } };
        }
        double rad = -(angle * Math.PI / 180.0);
        double[,] rotation = new double[,] {
            {Math.Cos(rad), -Math.Sin(rad)},
            {Math.Sin(rad),  Math.Cos(rad)}
        };
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rotation.GetLength(1); j++)
            {
                double temp = 0;
                for (int k = 0; k < cols; k++)
                {
                    temp += matrix[i, k] * rotation[k, j];
                }
                result[i, j] = temp;
            }
        }
        return result;
    }
}