using System;

namespace algorithm_lab1
{
    public  abstract class Sort
    {
        public int[] Array { get; private set; }

        public Sort(int[] array)
        {
            Array = array;
        }

        public int[] Sorting()
        {
            Console.WriteLine("Parent's class method worked!");
            return new int[0];
        }

        protected void Swap(int i, int j)
        {
            int temp = Array[i];
            Array[i] = Array[j];
            Array[j] = temp;
        }
    }
}
