using System;

namespace algorithm_lab1
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = Helper.getRandomArray(100);
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

            foreach (int el in tS.Array)
            {
                Console.Write(el + ", ");
            }
        }
    }
}
