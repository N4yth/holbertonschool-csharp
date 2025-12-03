using System;
using System.Collections.Generic;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int i, j;
        int[,] squareMatrix = new int[myMatrix.GetLength(0),myMatrix.GetLength(1)];

        for (i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (j = 0; j < myMatrix.GetLength(1); j++)
            {
               squareMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }
        return squareMatrix;
    }
}