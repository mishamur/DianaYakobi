using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodFullSqr
{
    public static class FullSqr
    {
        public static double[][] MatrixTransport(double[][] matrix)
        {
            double[][] result = new double[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    if(i == 0)
                        result[j] = new double[matrix[i].Length];
                    result[j][i] = matrix[i][j];
                }
            }
            return result;
        }

        public static double[][] MultMatrix(double[][] matrix)
        {
            double[][] resultMatrix = new double[matrix.Length][];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {


                }
            }

            throw new Exception();

        }

    }
}
