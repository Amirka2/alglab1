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
            QuickSorting(Array, 0, Array.Length - 1);
        }
        private static void QuickSorting(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSorting(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSorting(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
    }
}
