using System;
namespace algorithm_lab1
{
    public class QuickSort : Algorithm
    {
        public QuickSort(int[] array) : base(array)
        {
        }

        public override void Calculate()
        {
            QuickSorting(0, Array.Length - 1);
        }
        private void QuickSorting(int left, int right)
        {
            if(left < right)
            {
                int q = Partition(left, right);
                QuickSorting(left, q);
                QuickSorting(q + 1, right);
            }
        }
        private int Partition(int left, int right)
        {
            int delim = Array[(left + right) / 2];
            int i = left;
            int j = right;

            while(i <= j)
            {
                while(Array[i] < delim)
                    i++;
                while (Array[j] > delim)
                    j--;
                if (i >= j)
                    break;
                Swap(i, j);
            }
            return j;
        }
    }
}
