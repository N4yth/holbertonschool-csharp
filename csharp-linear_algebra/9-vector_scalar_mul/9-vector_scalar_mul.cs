using System;
using System.Collections.Generic;
using System.Linq;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Count() == 2 || vector.Count() == 3)
        {
            if (vector.Count() == 2)
            {
                double[] result = {vector[0] * scalar, vector[1] * scalar};
                return result;
            }
            else
            {
                double[] result = {vector[0] * scalar, vector[1] * scalar, vector[2] * scalar};
                return result;
            }   
        }
        else
        {
            double[] result = {-1};
            return result;
        }
    }
}