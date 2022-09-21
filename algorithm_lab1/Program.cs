using System;

namespace algorithm_lab1
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = Helper.getRandomArray(100);
            int[,] arr1 = { { 1, 2, 2 }, { 3, 1, 1 } };
            int[,] arr2 = { { 4, 2 }, { 3, 1 }, { 1, 5 } };
            Matrix m1 = new Matrix(arr1);
            Matrix m2 = new Matrix(arr2);
            MatrixMultiplier matrixMultiplier = new MatrixMultiplier(m1, m2);
            matrixMultiplier.Calculate();
            matrixMultiplier.ResultMatrix.PrintMatrix();

            //Const con = new Const(arr);
            BubbleSort bS = new(arr);
            QuickSort qS = new(arr);
            TimSort tS = new(arr);
            InsertionSort iS = new(arr);

            //bS.Calculate();
            //qS.Calculate();
            //tS.Calculate();
            tS.Calculate();
            //iS.Calculate();

            //foreach (int el in bS.Array)
            //{
            //    Console.Write(el);
            //}
            //Console.WriteLine("bubblesort");

            //foreach (int el in qS.Array)
            //{
            //    Console.Write(el);
            //}
            //Console.WriteLine("quicksort");

            //foreach (int el in tS.Array)
            //{
            //    Console.Write(el + ", ");
            //}
        }
    }
}
