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

        static public int[,] FormatXandY(string data) // time and n
        {
            string[] strArray = data.Split(" ");
            int rows = strArray.Length / 2;
            int[,] coordinates = new int[rows, 2];

            for(int i = 0; i < rows; i++)
            {
                coordinates[i, 0] = Int32.Parse(strArray[i * 2]);
                coordinates[i, 1] = Int32.Parse(strArray[i * 2 + 1]);
            }

            return coordinates;
        }

        static public void CreateCSVFile(string path, int[,] coordinates)
        {
            using (StreamWriter sw = new(path))
            {
                sw.WriteLine("n;time;");
                int columns = coordinates.GetLength(0) + 1;
                int rows = coordinates.Length / columns;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        sw.Write(coordinates[i,j] + ";");
                    }
                    Console.WriteLine();
                }
            }
        }

        static public int MakeMeasure(Algorithm algorithm, int n, int step)
        {
            int ticksPerMicrosecond = 10;
            Stopwatch stopWatch = new();

            stopWatch.Start();
            algorithm.Calculate();
            stopWatch.Stop();
            
            long ticks = stopWatch.ElapsedTicks;
            int microseconds = (int)ticks / ticksPerMicrosecond;

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
