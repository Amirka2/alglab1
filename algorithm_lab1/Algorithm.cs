using System;
namespace algorithm_lab1
{
    public abstract class Algorithm
    {
        public int[] Array { get; private set; }

        public Algorithm()
        {
        }
        public Algorithm(int[] array)
        {
            Array = array;
        }

        public virtual void Calculate()
        {
            Console.WriteLine("Parent's class method worked!");
        }
    }
}
