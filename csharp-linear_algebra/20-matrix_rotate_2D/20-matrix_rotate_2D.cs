using System;
using System.Collections.Generic;
using System.Security.AccessControl;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols)
        {
            return new double[,] { { -1 } };
        }
        angle = -angle;
        double[,] rotation = new double[,] {
            {Math.Cos(angle), -Math.Sin(angle)},
            {Math.Sin(angle),  Math.Cos(angle)}
        };
        int Rcol = rotation.GetLength(1);
        double[,] result = new double[rows, Rcol];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < Rcol; j++)
            {
                double temp = 0;
                for (int k = 0; k < cols; k++)
                {
                    temp += matrix[i, k] * rotation[k, j];
                }
                result[i, j] = Math.Round(temp, 2);
            }
        }
        return result;
    }
}