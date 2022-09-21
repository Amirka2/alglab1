using System;
namespace algorithm_lab1
{
    public class InsertionSort : Algorithm
    {
        private int Key;
        public InsertionSort(int[] array) : base(array)
        {
        }

        public override void Calculate()
        {
            InsertionSorting(Array, 0, Array.Length - 1);
        }
        public void SortSubArray(int[] array, int left, int right)
        {
            InsertionSorting(array, left, right);
        }
        private void InsertionSorting(int[] array, int left, int right)
        {
            for(int i = left; i < right; i++)
            {
                Key = Array[i + 1];
                Move(i);
            }
        }
        private void Move(int index)
        {
            while(index >= 0)
            { 
                if (Key < Array[index])
                    Swap(index + 1, index);
                index--;
            }
        }
    }
}
