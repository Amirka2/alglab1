using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace algorithm_lab1
{
    public static class Helper
    {
        static public void SaveData(string path, string data)
        {
            using (StreamWriter sw = new(path))
            {
                sw.WriteLine(data);
            }
        }

        static public string GetData(string path)
        {
            StringBuilder sb = new();
            using (StreamReader sr = new(path))
            {
                while (sr.ReadLine() != null)
                {
                    sb.Append(sr.ReadLine());
                }
            }
            return sb.ToString();
        }

        static public void DeleteData(string path)
        {
            File.Delete(path);
        }

        static public void DeleteData(string[] paths)
        {
            for (int i = 0; i < paths.Length; i++)
            {
                File.Delete(paths[i]);
            }
        }

        static public long[,] FormatXandY(string data) // time and n
        {
            string[] strArray = data.Split(" ");
            int rows = strArray.Length / 2;
            long[,] coordinates = new long[rows, 2];

            for(int i = 0; i < rows; i++)
            {
                coordinates[i, 0] = Int64.Parse(strArray[i * 2]);
                coordinates[i, 1] = Int64.Parse(strArray[i * 2 + 1]);
            }

            return coordinates;
        }

        static public long[,] FormatMatrixData(string data) // n, m and time
        {
            string[] strArray = data.Split(" ");
            int rows = strArray.Length / 3;
            long[,] coordinates = new long[rows, 3];

            for (int i = 0; i < rows; i++)
            {
                coordinates[i, 0] = Int64.Parse(strArray[i * 2]);
                coordinates[i, 1] = Int64.Parse(strArray[i * 2 + 1]);
                coordinates[i, 2] = Int64.Parse(strArray[i * 2 + 2]);
            }

            return coordinates;
        }

        static public void CreateCSVFile(string path, long[,] coordinates, bool append)
        {
            using StreamWriter sw = new(path, append);
            int columns = coordinates.GetUpperBound(1) + 1;
            int rows = coordinates.Length / columns;

            if (columns == 3)
                sw.WriteLine("n;m;time;");
            else
                sw.WriteLine("n;time;");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sw.Write(coordinates[i, j] + ";");
                }
                Console.WriteLine();
            }
        }
        static public void CreateCSVFile(string path, long[,] coordinates)
        {
            using StreamWriter sw = new(path, true);
            int columns = coordinates.GetUpperBound(1) + 1;
            int rows = coordinates.Length / columns;

            sw.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sw.Write(coordinates[i, j] + ";");
                }
                Console.WriteLine();
            }
        }

        static public long MakeMeasure(Algorithm algorithm)
        {
            long ticksPerMicrosecond = 10L;
            Stopwatch stopWatch = new();

            stopWatch.Start();
            algorithm.Calculate();
            stopWatch.Stop();
            
            long ticks = stopWatch.ElapsedTicks;
            long microseconds = ticks / ticksPerMicrosecond;

            return microseconds;
        }

        static public long MakeMeasureForEuclid(int a, int b)
        {
            long ticksPerMicrosecond = 10L;
            Stopwatch stopWatch = new();

            stopWatch.Start();
            Euclid.EuclidAlg(a, b);
            stopWatch.Stop();

            long ticks = stopWatch.ElapsedTicks;
            long microseconds = ticks / ticksPerMicrosecond;

            return microseconds;
        }

        public static int[] GetRandomArray(int length)
        {
            int[] arr = new int[length];
            Random rnd = new();
            int i = 0;

            while (i < length)
            {
                arr[i] = rnd.Next(0, 100);
                i++;
            }

            return arr;
        }

        public static int[,] GetRandomMatrix(int i, int j)
        {            
            int[,] matrix = new int[i, j];
            Random rnd = new();

            for(int row = 0; row < i; row++)
            {
                for(int col = 0; col < j; col++)
                {
                    matrix[row, col] = rnd.Next(0, 100);
                }
            }

            return matrix;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.WriteLine();
        }
    }
}
