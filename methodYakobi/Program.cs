//example uncomment for check
//const int n = 3;
//double[][] arr = new double[n][];
//arr[0] = new double[] { -4, 1, 1 };
//arr[1] = new double[] { 1, -9, 3 };
//arr[2] = new double[] { 1, 2, -16};
//
//double[] b = new double[n] {2, 5, 13};
//
//double eps = 2 * Math.Pow(10, -2);


const int n = 5;
const int m = 5;
const int k = 21; //ОсиповаДианаАндреевна

double[][] arr = new double[n][];
arr[0] = new double[] { 12 + k, 2, m / 4, 1, 2 };
arr[1] = new double[] { 4, 113 + k, 1, m / 10, m - 4 };
arr[2] = new double[] { 1, 2, -24 - k, 3, 4 };
arr[3] = new double[] { 1, 2 / m, 4, 33 + k, 4 };
arr[4] = new double[] { -1, 2, -3, 3 + m, -44 - k };

double[] b = new double[n] { 1, 2, 3, 4, 5 };

double eps = 2 * Math.Pow(10, -4);


methodYakobi.Yakobi.Calc(arr, b, eps);

Console.WriteLine();
