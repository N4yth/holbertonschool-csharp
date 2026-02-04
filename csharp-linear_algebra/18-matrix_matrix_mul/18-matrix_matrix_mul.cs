using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int row1 = matrix1.GetLength(0);
        int col1 = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);
        int col2 = matrix2.GetLength(1);

        if (col1 != row2)
        {
            ouble[,] result = {{-1}};
            return result;
        }
        else
        {
            double[,] result = new double[row1, col2];
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < col1; k++)
                    {
                        temp += A[i, k] * B[k, j];
                    }
                    result[i, j] = temp;
                }
            }
            return result;
        }
    }
}