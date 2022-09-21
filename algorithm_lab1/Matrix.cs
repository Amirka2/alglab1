using System;
namespace algorithm_lab1
{
    public class Matrix 
    {
        public int[,] Value { get; private set; }
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public Matrix(int[,] matrix)
        {
            Value = (int[,])matrix.Clone();
            Columns = matrix.GetUpperBound(0) + 1;
            Rows = matrix.Length / Columns;
        }

        public void PrintMatrix()
        {
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Columns; j++)
                {
                    Console.Write(Value[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
