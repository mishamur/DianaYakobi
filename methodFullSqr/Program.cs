using System;
using methodYakobi;



namespace methodFullSqr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example uncomment for check
            const int n = 3;
            double[][] arr = new double[n][];
            arr[0] = new double[] { -4, 1, 1 };
            arr[1] = new double[] { 1, -9, 3 };
            arr[2] = new double[] { 1, 2, -16};
            
            double[] b = new double[n] {2, 5, 13};
            
            double eps = 2 * Math.Pow(10, -2);
            Yakobi.PrintMatrixAtConsole(FullSqr.MatrixTransport(arr));

        }
    }
}
