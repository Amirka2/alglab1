using System;
namespace algorithm_lab1
{
    public class TimSort : Algorithm
    {
        private int MinRun = 32;

        public TimSort(int[] array) : base(array)
        {
        }

        public override void Calculate()
        {
            //MinRun = GetMinRun(Array.Length);
            TimSorting(Array.Length);
        }

        private void TimSorting(int n)
        {
            for (int i = 0; i < n; i += MinRun)
            {
                InsertionSort insertionSort = new InsertionSort(Array);
                insertionSort.SortSubArray(Array, i, Math.Min((i + MinRun - 1), (n - 1)));
            }

            for (int size = MinRun; size < n;
                                     size = 2 * size)
            {

                for (int left = 0; left < n;
                                      left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min((left +
                                        2 * size - 1), (n - 1));

                    if (mid < right)
                        Merge(left, mid, right);
                }
            }
        }

        private int GetMinRun(int n)
        {
            int r = 0;
            while(n >= 64)
            {
                r |= n & 1;
                n >>= 1;
            }
            return n + r;
        }

        private void Merge(int l, int m, int r)
        {
            int len1 = m - l + 1, len2 = r - m;
            int[] left = new int[len1];
            int[] right = new int[len2];
            for (int x = 0; x < len1; x++)
                left[x] = Array[l + x];
            for (int x = 0; x < len2; x++)
                right[x] = Array[m + 1 + x];

            int i = 0;
            int j = 0;
            int k = l;

            while (i < len1 && j < len2)
            {
                if (left[i] <= right[j])
                {
                    Array[k] = left[i];
                    i++;
                }
                else
                {
                    Array[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < len1)
            {
                Array[k] = left[i];
                k++;
                i++;
            }

            while (j < len2)
            {
                Array[k] = right[j];
                k++;
                j++;
            }
        }
    }
}
