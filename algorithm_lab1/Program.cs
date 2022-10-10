using System;

namespace algorithm_lab1
{
    class Program
    {
        private static void Main(string[] args)
        {
            int n = 1000000;
            int m = n * 5;

            MeasureConst(n);
            //Helper.CalculateAndWriteAverages("constData.csv", n);

            //MeasureSummator(n);
            //Helper.CalculateAndWriteAverages("summatorData.csv", n);

            //MeasureMultiplier(n);
            //Helper.CalculateAndWriteAverages("multiplierData.csv", n);

            //MeasureGorner(n);
            //Helper.CalculateAndWriteAverages("gornerData.csv", n + 20000);

            //MeasureBubbleSort(n);
            //Helper.CalculateAndWriteAverages("bubbleSortData.csv", n);

            //MeasureQuickSort(n);
            //Helper.CalculateAndWriteAverages("quickSortData.csv", n);

            //MeasureTimSort(n * 2);
            //Helper.CalculateAndWriteAverages("timSortData.csv", n * 2);
            //int x = 2, n = 2;                     //степени
            //MeasureAllSteps(x, n, 1000);

            //int[,] arr1 = Helper.GetRandomMatrix(1, 1);
            //int[,] arr2 = Helper.GetRandomMatrix(1, 1);

            //Matrix m1 = new(arr1);
            //Matrix m2 = new(arr2);

            //MatrixMultiplier matrixMultiplier = new(m1, m2);
            //MeasureAndWriteMatrixData(matrixMultiplier, "matrixesData.csv", false);

            //for (int i = 1; i <= 100; i++)
            //{
            //    MeasureAllMatrixes(i, 1, 1, 100);
            //}

            //MeasureGnomeSort(10000);
            //MeasureFibonachi(n);
            //MeasureEuclid(1000);
            //Helper.MakeMatrixTable("matrixesData.csv", 100, 100);
        }

        public static void MeasureConst(int n)
        {
            int[][] arrays = Helper.GetRandomArrays(n);

            Const con = new(arrays[0]);
            MeasureAndWriteData(con, "constData.csv", false);

            for (int i = 100; i <= n; i += 100)
            {
                con = new(arrays[i]);
                MeasureAndWriteData(con, "constData.csv");
            }
            for (int i = 0; i < 5; i++)
            {
                //SupplementConst(arrays, n);
            }
        }
        public static void SupplementConst(int[][] arrays, int n)
        {
            Const con = new(arrays[0]);

            for (int i = 100; i <= n; i += 100)
            {
                con = new(arrays[i]);
                MeasureAndWriteData(con, "constData.csv");
            }
        }

        public static void MeasureSummator(int n)
        {
            int[][] arrays = Helper.GetRandomArrays(n);

            Summator summator = new(arrays[0]);
            MeasureAndWriteData(summator, "summatorData.csv", false);

            for (int i = 100; i <= n; i += 100)
            {
                summator = new(arrays[i]);
                MeasureAndWriteData(summator, "summatorData.csv");
            }
            for (int i = 0; i < 5; i++)
            {
                //SupplementTimSort(arrays, n);
            }
        }
        public static void SupplementSummator(int[][] arrays, int n)
        {
            Summator summator = new(arrays[0]);

            for (int i = 100; i <= n; i += 100)
            {
                summator = new(arrays[i]);
                MeasureAndWriteData(summator, "summatorData.csv");
            }
        }

        public static void MeasureMultiplier(int n)
        {
            int[][] arrays = Helper.GetRandomArrays(n);

            Multiplier multiplier = new(arrays[0]);
            MeasureAndWriteData(multiplier, "multiplierData.csv", false);

            for (int i = 100; i <= n; i += 100)
            {
                multiplier = new(arrays[i]);
                MeasureAndWriteData(multiplier, "multiplierData.csv");
            }
            for (int i = 0; i < 5; i++)
            {
                //SupplementMultiplier(arrays, n);
            }
        }
        public static void SupplementMultiplier(int[][] arrays, int n)
        {
            Multiplier multiplier = new(arrays[0]);

            for (int i = 100; i <= n; i += 100)
            {
                multiplier = new(arrays[i]);
                MeasureAndWriteData(multiplier, "multiplierData.csv");
            }
        }

        public static void MeasureGorner(int n)
        {
            int[][] arrays = Helper.GetRandomArrays(n);

            GornerMethod gorner = new(arrays[0]);
            MeasureAndWriteData(gorner, "gornerData.csv", false);

            for (int i = 100; i <= n; i += 100)
            {
                gorner = new(arrays[i]);
                MeasureAndWriteData(gorner, "gornerData.csv");
            }
            for (int i = 0; i < 5; i++)
            {
                //SupplementGorner(arrays, n);
            }
        }
        public static void SupplementGorner(int[][] arrays, int n)
        {
            GornerMethod gorner = new(arrays[0]);

            for (int i = 100; i <= n; i += 100)
            {
                gorner = new(arrays[i]);
                MeasureAndWriteData(gorner, "gornerData.csv");
            }
        }

        public static void MeasureQuickSort(int n) {
            int[][] arrays = Helper.GetRandomArrays(n);

            QuickSort qS = new(arrays[0]);
            MeasureAndWriteData(qS, "quickSortData.csv", false);

            for (int i = 100; i <= n; i += 100)
            {
                qS = new(arrays[i]);
                MeasureAndWriteData(qS, "quickSortData.csv");
            }
            for (int i = 0; i < 5; i++)
            {
                //SupplementQuickSort(arrays, n);
            }
        }
        public static void SupplementQuickSort(int[][] arrays, int n)
        {
            QuickSort qS = new(arrays[0]);

            for (int i = 100; i <= n; i += 100)
            {
                qS = new(arrays[i]);
                MeasureAndWriteData(qS, "quickSortData.csv");
            }
        }

        public static void MeasureBubbleSort(int n)
        {
            int[][] arrays = Helper.GetRandomArrays(n);

            BubbleSort bS = new(arrays[0]);
            MeasureAndWriteData(bS, "bubbleSortData.csv", false);

            for (int i = 100; i <= n; i += 100)
            {
                bS = new(arrays[i]);
                MeasureAndWriteData(bS, "bubbleSortData.csv");
            }
            for (int i = 0; i < 5; i++)
            {
                //SupplementBubbleSort(arrays, n);
            }
        }
        public static void SupplementBubbleSort(int[][] arrays, int n)
        {
            BubbleSort bS = new(arrays[0]);

            for (int i = 100; i <= n; i += 100)
            {
                bS = new(arrays[i]);
                MeasureAndWriteData(bS, "bubbleSortData.csv");
            }
        }

        public static void MeasureTimSort(int n)
        {
            int[][] arrays = Helper.GetRandomArrays(n);

            TimSort timSort = new(arrays[0]);
            MeasureAndWriteData(timSort, "timSortData.csv", false);

            for (int i = 100; i <= n; i += 100)
            {
                timSort = new(arrays[i]);
                MeasureAndWriteData(timSort, "timSortData.csv");
            }
            for (int i = 0; i < 5; i++)
            {
                //SupplementTimSort(arrays, n);
            }
        }
        public static void SupplementTimSort(int[][] arrays, int n)
        {
            TimSort timSort = new(arrays[0]);

            for (int i = 100; i <= n; i += 100)
            {
                timSort = new(arrays[i]);
                MeasureAndWriteData(timSort, "timSortData.csv");
            }
        }

        public static void MeasureAllSteps(int x, int n, int iter)
        {
            Exponentiation ex = new(x, n);
            ex.Pow(x, n);
            MeasureAndWriteExpData(ex, "powStandartData.csv", false);

            ex = new(x, n);
            ex.RecPow(x, n);
            MeasureAndWriteExpData(ex, "powRecursiveData.csv", false);

            ex = new(x, n);
            ex.QuickPow(x, n);
            MeasureAndWriteExpData(ex, "powQuickData.csv", false);

            ex = new(x, n);
            ex.ClassicQuickPow(x, n);
            MeasureAndWriteExpData(ex, "powClassicQuickData.csv", false);

            for(int i = 0; i < 5; i++)
            {
                //SupplementSteps(x, n, iter);
            }
        }
        public static void SupplementSteps(int x, int n, int iter)
        {
            Exponentiation ex = new(x, n);

            for (int i = 1; i < iter; i++)
            {
                ex = new(x, n + i);
                ex.Pow(x, n + i);
                MeasureAndWriteExpData(ex, "powStandartData.csv", true);

                ex = new(x, n + i);
                ex.RecPow(x, n + i);
                MeasureAndWriteExpData(ex, "powRecursiveData.csv", true);

                ex = new(x, n + i);
                ex.QuickPow(x, n + i);
                MeasureAndWriteExpData(ex, "powQuickData.csv", true);

                ex = new(x, n + i);
                ex.ClassicQuickPow(x, n + i);
                MeasureAndWriteExpData(ex, "powClassicQuickData.csv", true);
            }
        }

        public static void MeasureAllMatrixes(int n, int m, int step, int iter)
        {
            int[,] arr1 = Helper.GetRandomMatrix(n, m);
            int[,] arr2 = Helper.GetRandomMatrix(m, n);

            Matrix m1 = new(arr1);
            Matrix m2 = new(arr2);

            MatrixMultiplier matrixMultiplier = new(m1, m2);
            MeasureAndWriteMatrixData(matrixMultiplier, "matrixesData.csv", true);


            for(int i = 0; i < iter - 1; i++)
            {
                m += step;

                arr1 = Helper.GetRandomMatrix(n, m);
                arr2 = Helper.GetRandomMatrix(m, n);

                m1 = new(arr1);
                m2 = new(arr2);

                matrixMultiplier = new(m1, m2);
                MeasureAndWriteMatrixData(matrixMultiplier, "matrixesData.csv", true);
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    throw new Exception("matrixes need fix");
            //    SupplementMatrixes();
            //}
        }
        public static void SupplementMatrixes(int[][] arrays, int n)
        {

        }

        public static void MeasureFibonachi(int n)
        {
            int[][] arrays = Helper.GetRandomArrays(n);

            Fibonachi fibonachi = new(arrays[0]);
            MeasureAndWriteData(fibonachi, "fibonachiData.csv", false);

            for (int i = 1; i < n; i++)
            {
                fibonachi = new(arrays[i]);
                MeasureAndWriteData(fibonachi, "fibonachiData.csv");
            }
            for (int i = 0; i < 5; i++)
            {
                //SupplementFibonachi(arrays, n);
            }
        }
        public static void SupplementFibonachi(int[][] arrays, int n)
        {
            Fibonachi fibonachi = new(arrays[0]);

            for (int i = 1; i < n; i++)
            {
                fibonachi = new(arrays[i]);
                MeasureAndWriteData(fibonachi, "fibonachiData.csv");
            }
        }

        public static void MeasureEuclid(int n = 10000)
        {
            int a, b;
            for (int i = 10; i <= n; i += 10)
            {
                for (int j = 10; j <= n; j += 10)
                {
                    a = i;
                    b = j;
                    long microseconds = Helper.MakeMeasureForEuclid(a, b);
                    string data = $"{a} {b} {microseconds}";
                    long[,] coordinates = Helper.FormatMatrixData(data);
                    Helper.CreateCSVFile("euclidData.csv", coordinates);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                //SupplementEuclid(n);
            }
        }
        public static void SupplementEuclid(int n)
        {
            int a, b;
            for (int i = 10; i <= n; i += 10)
            {
                for (int j = 10; j <= n; j += 10)
                {
                    a = i;
                    b = j;
                    long microseconds = Helper.MakeMeasureForEuclid(a, b);
                    string data = $"{a} {b} {microseconds}";
                    long[,] coordinates = Helper.FormatMatrixData(data);
                    Helper.CreateCSVFile("euclidData.csv", coordinates);
                }
            }
        }

        public static void MeasureGnomeSort(int n)
        {
            int[][] arrays = Helper.GetRandomArrays(n);

            GnomeSort gnomeSort = new(arrays[0]);
            MeasureAndWriteData(gnomeSort, "gnomeSortData.csv", false);

            for (int i = 100; i <= n; i += 100)
            {
                gnomeSort = new(arrays[i]);
                MeasureAndWriteData(gnomeSort, "gnomeSortData.csv");
            }
            for (int i = 0; i < 5; i++)
            {
                //SupplementGnomeSort(arrays, n);
            }
        }
        public static void SupplementGnomeSort(int[][] arrays, int n)
        {
            GnomeSort gnomeSort = new(arrays[0]);

            for (int i = 100; i <= n; i += 100)
            {
                gnomeSort = new(arrays[i]);
                MeasureAndWriteData(gnomeSort, "gnomeSortData.csv");
            }
        }





        public static void MeasureAndWriteExpData(Exponentiation ex, string path, bool append)
        {
            long steps = ex.StepCount;
            string data = $"{ex.X} {ex.N} {steps}";
            long[,] coordinates = Helper.FormatMatrixData(data);
            if (append)
                Helper.CreateCSVFile(path, coordinates);
            else
                Helper.CreateCSVFile(path, coordinates, append);
        }
        public static void MeasureAndWriteMatrixData(MatrixMultiplier multiplier, string path, bool append)
        {
            long microseconds = Helper.MakeMeasure(multiplier);        
            string data = $"{multiplier.Matrix1.Rows} {multiplier.Matrix1.Columns} {microseconds}";
            long[,] coordinates = Helper.FormatMatrixData(data);
            if(append)
                Helper.CreateCSVFile(path, coordinates);
            else
                Helper.CreateCSVFile(path, coordinates, append);
        }
        public static void MeasureAndWriteData(Algorithm algorithm, string path, bool append)
        {
            long microseconds = Helper.MakeMeasure(algorithm);        
            string data = $"{algorithm.Array.Length} {microseconds}";
            long[,] coordinates = Helper.FormatXandY(data);
            Helper.CreateCSVFile(path, coordinates, append);
        }
        public static void MeasureAndWriteData(Algorithm algorithm, string path)
        {
            long microseconds = Helper.MakeMeasure(algorithm);        
            string data = $"{algorithm.Array.Length} {microseconds}";
            long[,] coordinates = Helper.FormatXandY(data);
            Helper.CreateCSVFile(path, coordinates);
        }
    }
}
