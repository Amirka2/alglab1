using System;
namespace algorithm_lab1
{
    public class BubbleSort : Algorithm
    {

        public BubbleSort(int[] array) : base(array)
        {
        }

        public override void Calculate()
        {
            for(int i = 0; i < Array.Length; i++)
            {
                for(int j = 0; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                        Swap(i, j);
                }
            }
        }
    }
}
