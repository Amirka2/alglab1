using System;
namespace algorithm_lab1
{
    public class MatrixMultiplier : Algorithm
    {
        public Matrix Matrix1 { get; private set; }
        public Matrix Matrix2 { get; private set; }
        public Matrix ResultMatrix { get; private set; }


        public MatrixMultiplier(Matrix m1, Matrix m2)
        {
            Matrix1 = m1;
            Matrix2 = m2;
        }

        public override void Calculate()
        {
            Multiply(Matrix1, Matrix2);
        }

        private void Multiply(Matrix m1, Matrix m2)
        {
            if(IsCorrect(m1, m2))
            {
                int[,] resultArray = new int[m1.Columns, m2.Rows];

                for (int i = 0; i < m1.Columns; i++)
                {
                    for (int j = 0; j < m2.Rows; j++)
                    {
                        for (int k = 0; k < m2.Columns; k++)
                        {
                            resultArray[i, j] += m1.Value[i, k] * m2.Value[k, j];
                        }
                    }
                }

                Matrix mRes = new Matrix(resultArray);
                ResultMatrix = mRes;
            }
        }

        private bool IsCorrect(Matrix m1, Matrix m2)
        {
            return m1.Columns == m2.Rows;
        }
    }
}
