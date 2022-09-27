using System;
namespace algorithm_lab1
{
    public class GnomeSort : Algorithm
    {
        public GnomeSort(int[] array) : base(array)
        {
        }

        public void GnomeSortAlg(int[] inArray)
        {
            int i = 1;
            int j = 2;
            while (i < inArray.Length)
            {
                if (inArray[i - 1] < inArray[i])
                {
                    i = j;
                    j += 1;
                }
                else
                {
                    Swap(i - 1, i);
                    i -= 1;
                    if (i == 0)
                    {
                        i = j;
                        j += 1;
                    }
                }
            }
        }
    }
}
