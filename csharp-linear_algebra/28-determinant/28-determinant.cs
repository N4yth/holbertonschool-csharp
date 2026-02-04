using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading.Tasks.Dataflow;
using System.Xml.XPath;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(1) != 2 || matrix.GetLength(1) != 3 && (matrix.GetLength(0) == matrix.GetLength(1)))
        {
            return new double[,] {{-1}};
        }
        double result;
        if (matrix.GetLength(1) == 2)
        {
            result = matrix[0, 0]*matrix[1, 1] - matrix[0, 1]*matrix[1, 0];
        }
        else
        {
            return matrix[0,0]*matrix[1,1]*matrix[2,2]
                + matrix[0,1]*matrix[1,2]*matrix[2,0]
                + matrix[0,2]*matrix[1,0]*matrix[2,1]
                - matrix[0,2]*matrix[1,1]*matrix[2,0]
                - matrix[0,1]*matrix[1,0]*matrix[2,2]
                - matrix[0,0]*matrix[1,2]*matrix[2,1];
        }
        return result;
    }
}