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
        double Tangle = angle * Math.PI / 180.0;
        double[,] rotation = new double[,] {
            { Math.Cos(Tangle), -Math.Sin(Tangle) },
            { Math.Sin(Tangle),  Math.Cos(Tangle) }
        };
        double[,] result = new double[2, cols];
        for (int i = 0; i < cols; i++)
        {
            result[0, i] = rotation[0, 0] * matrix[0, i] + rotation[0, 1] * matrix[1, i];
            result[1, i] = rotation[1, 0] * matrix[0, i] + rotation[1, 1] * matrix[1, i];
        }
        return result;
    }
}