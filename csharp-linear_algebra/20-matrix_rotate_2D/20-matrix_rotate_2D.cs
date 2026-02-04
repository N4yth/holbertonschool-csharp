using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        double[,] rotation = new double[,] {{Math.Round(Math.Cos(angle)), Math.Round(-Math.Sin(angle))}, {Math.Round(Math.Sin(angle)), Math.Round(Math.Cos(angle))}};
        int Rcol = rotation.GetLength(1);
        if (row != 2)
        {
            double[,] result = {{-1}};
            return result;
        }
        else
        {
            double[,] result = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < Rcol; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < col; k++)
                    {
                        temp += matrix[i, k] * rotation[k, j];
                    }
                    result[i, j] = temp;
                }
            }
            return result;
        }
    }
}