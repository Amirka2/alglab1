using System;

namespace algorithm_lab1
{
    class Program
    {
        private static void Main(string[] args)
        {
            //int x = 2, n = 4;                     //степени
            //MeasureAllSteps(x, n, 1000);

            //MeasureAllMatrixes(10, 15, 10, 50);   //матрицы

            //MeasureAllAlgorithms();               //все сортировки и сум/умножение

            //MeasureEuclid("euclidData.csv", false);
            //for(int i = 0; i < 1000; i++)
            //{
            //    MeasureEuclid("euclidData.csv", true);
            //}
        }

        public static void MeasureEuclid(string path, bool append)
        {
            Random rnd = new();
            int a = rnd.Next(1, 100000);
            int b = rnd.Next(1, 100000);

            long microseconds = Helper.MakeMeasureForEuclid(a, b);
            string data = $"{a} {b} {microseconds}";
            long[,] coordinates = Helper.FormatMatrixData(data);

            if (append)
                Helper.CreateCSVFile(path, coordinates);
            else
                Helper.CreateCSVFile(path, coordinates, append);
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

            for(int i = 1; i < iter; i++)
            {
                ex = new(x + i, n + i);
                ex.Pow(x + i, n + i);
                MeasureAndWriteExpData(ex, "powStandartData.csv", true);

                ex = new(x + i, n + i);
                ex.RecPow(x + i, n + i);
                MeasureAndWriteExpData(ex, "powRecursiveData.csv", true);

                ex = new(x + i, n + i);
                ex.QuickPow(x + i, n + i);
                MeasureAndWriteExpData(ex, "powQuickData.csv", true);

                ex = new(x + i, n + i);
                ex.ClassicQuickPow(x + i, n + i);
                MeasureAndWriteExpData(ex, "powClassicQuickData.csv", true);
            }

        }
        public static void MeasureAllAlgorithms()
        {
            int[] array = Helper.GetRandomArray(1000);
            int[] array1 = Helper.GetRandomArray(10000);
            int[] array2 = Helper.GetRandomArray(15000);
            int[] array3 = Helper.GetRandomArray(20000);
            int[] array4 = Helper.GetRandomArray(25000);
            int[] array5 = Helper.GetRandomArray(30000);
            int[] array6 = Helper.GetRandomArray(35000);
            int[] array7 = Helper.GetRandomArray(45000);
            int[] array8 = Helper.GetRandomArray(50000);



            Const constant = new(array);
            Summator summator = new(array);
            Multiplier multiplier = new(array);
            GornerMethod gornerMethod = new(array);
            BubbleSort bS = new(array);
            QuickSort qS = new(array);
            TimSort tS = new(array);
            GnomeSort gS = new(array);
            //Fibonachi fibonachi = new(array); //использует длину массива как н

            MeasureAndWriteData(constant, "constData.csv", false);
            MeasureAndWriteData(summator, "summatorData.csv", false);
            MeasureAndWriteData(multiplier, "multiplierData.csv", false);
            MeasureAndWriteData(gornerMethod, "gornerData.csv", false);
            MeasureAndWriteData(bS, "bubbleSortData.csv", false);
            MeasureAndWriteData(tS, "timSortData.csv", false);
            MeasureAndWriteData(gS, "gnomeSortData.csv", false);


            constant = new(array1);
            summator = new(array1);
            multiplier = new(array1);
            gornerMethod = new(array1);
            bS = new(array1);
            qS = new(array1);
            tS = new(array1);
            gS = new(array1);

            MeasureAndWriteData(constant, "constData.csv");
            MeasureAndWriteData(summator, "summatorData.csv");
            MeasureAndWriteData(multiplier, "multiplierData.csv");
            MeasureAndWriteData(gornerMethod, "gornerData.csv");
            MeasureAndWriteData(bS, "bubbleSortData.csv");
            MeasureAndWriteData(tS, "timSortData.csv");
            MeasureAndWriteData(gS, "gnomeSortData.csv");


            constant = new(array2);
            summator = new(array2);
            multiplier = new(array2);
            gornerMethod = new(array2);
            bS = new(array2);
            tS = new(array2);
            gS = new(array2);

            MeasureAndWriteData(constant, "constData.csv");
            MeasureAndWriteData(summator, "summatorData.csv");
            MeasureAndWriteData(multiplier, "multiplierData.csv");
            MeasureAndWriteData(gornerMethod, "gornerData.csv");
            MeasureAndWriteData(bS, "bubbleSortData.csv");
            MeasureAndWriteData(tS, "timSortData.csv");
            MeasureAndWriteData(gS, "gnomeSortData.csv");


            constant = new(array3);
            summator = new(array3);
            multiplier = new(array3);
            gornerMethod = new(array3);
            bS = new(array3);
            tS = new(array3);
            gS = new(array3);

            MeasureAndWriteData(constant, "constData.csv");
            MeasureAndWriteData(summator, "summatorData.csv");
            MeasureAndWriteData(multiplier, "multiplierData.csv");
            MeasureAndWriteData(gornerMethod, "gornerData.csv");
            MeasureAndWriteData(bS, "bubbleSortData.csv");
            MeasureAndWriteData(tS, "timSortData.csv");
            MeasureAndWriteData(gS, "gnomeSortData.csv");


            constant = new(array4);
            summator = new(array4);
            multiplier = new(array4);
            gornerMethod = new(array4);
            bS = new(array4);
            tS = new(array4);
            gS = new(array4);

            MeasureAndWriteData(constant, "constData.csv");
            MeasureAndWriteData(summator, "summatorData.csv");
            MeasureAndWriteData(multiplier, "multiplierData.csv");
            MeasureAndWriteData(gornerMethod, "gornerData.csv");
            MeasureAndWriteData(bS, "bubbleSortData.csv");
            MeasureAndWriteData(tS, "timSortData.csv");
            MeasureAndWriteData(gS, "gnomeSortData.csv");


            constant = new(array5);
            summator = new(array5);
            multiplier = new(array5);
            gornerMethod = new(array5);
            bS = new(array5);
            tS = new(array5);
            gS = new(array5);

            MeasureAndWriteData(constant, "constData.csv");
            MeasureAndWriteData(summator, "summatorData.csv");
            MeasureAndWriteData(multiplier, "multiplierData.csv");
            MeasureAndWriteData(gornerMethod, "gornerData.csv");
            MeasureAndWriteData(bS, "bubbleSortData.csv");
            MeasureAndWriteData(tS, "timSortData.csv");
            MeasureAndWriteData(gS, "gnomeSortData.csv");


            constant = new(array6);
            summator = new(array6);
            multiplier = new(array6);
            gornerMethod = new(array6);
            bS = new(array6);
            tS = new(array6);
            gS = new(array6);

            MeasureAndWriteData(constant, "constData.csv");
            MeasureAndWriteData(summator, "summatorData.csv");
            MeasureAndWriteData(multiplier, "multiplierData.csv");
            MeasureAndWriteData(gornerMethod, "gornerData.csv");
            MeasureAndWriteData(bS, "bubbleSortData.csv");
            MeasureAndWriteData(tS, "timSortData.csv");
            MeasureAndWriteData(gS, "gnomeSortData.csv");


            constant = new(array7);
            summator = new(array7);
            multiplier = new(array7);
            gornerMethod = new(array7);
            bS = new(array7);
            tS = new(array7);
            gS = new(array7);

            MeasureAndWriteData(constant, "constData.csv");
            MeasureAndWriteData(summator, "summatorData.csv");
            MeasureAndWriteData(multiplier, "multiplierData.csv");
            MeasureAndWriteData(gornerMethod, "gornerData.csv");
            MeasureAndWriteData(bS, "bubbleSortData.csv");
            MeasureAndWriteData(tS, "timSortData.csv");
            MeasureAndWriteData(gS, "gnomeSortData.csv");


            constant = new(array8);
            summator = new(array8);
            multiplier = new(array8);
            gornerMethod = new(array8);
            bS = new(array8);
            tS = new(array8);
            gS = new(array8);

            MeasureAndWriteData(constant, "constData.csv");
            MeasureAndWriteData(summator, "summatorData.csv");
            MeasureAndWriteData(multiplier, "multiplierData.csv");
            MeasureAndWriteData(gornerMethod, "gornerData.csv");
            MeasureAndWriteData(bS, "bubbleSortData.csv");
            MeasureAndWriteData(tS, "timSortData.csv");
            MeasureAndWriteData(gS, "gnomeSortData.csv");
        }
        public static void MeasureAllMatrixes(int n, int m, int step, int iter)
        {
            int[,] arr1 = Helper.GetRandomMatrix(n, m);
            int[,] arr2 = Helper.GetRandomMatrix(m, n);

            Matrix m1 = new(arr1);
            Matrix m2 = new(arr2);

            MatrixMultiplier matrixMultiplier = new(m1, m2);
            MeasureAndWriteMatrixData(matrixMultiplier, "matrixesData.csv", false);


            for(int i = 0; i < iter - 1; i++)
            {
                n += step;
                m += step;

                arr1 = Helper.GetRandomMatrix(n, m);
                arr2 = Helper.GetRandomMatrix(m, n);

                m1 = new(arr1);
                m2 = new(arr2);

                matrixMultiplier = new(m1, m2);
                MeasureAndWriteMatrixData(matrixMultiplier, "matrixesData.csv", true);
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
