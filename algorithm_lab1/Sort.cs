using System;
namespace algorithm_lab1
{
    public  abstract class Sort
    {
        private int[] array;

        public Sort(int[] array)
        {
            this.array = array;
        }

        public int[] Sorting()
        {
            return new int[0];
        }

        protected void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
