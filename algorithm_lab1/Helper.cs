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
                sw.WriteLine();
            }
        }
        static public void CreateCSVFile(string path, long[,] coordinates)
        {
            using StreamWriter sw = new(path, true);
            int columns = coordinates.GetUpperBound(1) + 1;
            int rows = coordinates.Length / columns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sw.Write(coordinates[i, j] + ";");
                }
                sw.WriteLine();
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

        public static int[][] GetRandomArrays(int length)
        {
            int[][] arr = new int[length][];
            Random rnd = new();

            for(int i = 0; i < length; i++)
            {
                arr[i] = new int[i];
                for (int j = 0; j < i; j++)
                {
                    arr[i][j] = rnd.Next(0, 1000);
                }
            }

            return arr;
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

        public static void CalculateAndWriteAverages(string path, int valuesAmount)
        {
            string resultData = GetAverageValues(path, valuesAmount).ToString();
            DeleteData(path);
            SaveData(path, resultData);
            long[,] coordinates = FormatXandY(path);
            CreateCSVFile(path, coordinates);
        }

        public static StringBuilder GetAverageValues(string path, int valuesAmount)
        {
            string input = GetString(path);
            string[] pairs = input.Split(';');
            StringBuilder results = new StringBuilder();

            for(int i = 2; i < valuesAmount * 2 - 1; i += 2)
            {
                int n = i;
                long averageTime = 0;
                for(int k = 0; k < 5; k++)
                {
                    long time = Int64.Parse(pairs[i + 1 + valuesAmount * k]);
                    averageTime += time;
                }
                averageTime /= 5;

                results.AppendLine($"{n};{averageTime};");
            }

            return results;
        }

        public static string GetString(string path)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using StreamReader streamReader = new StreamReader(path);
            streamReader.ReadLine();

            while (streamReader.ReadLine() != null)
            {
                stringBuilder.AppendLine(streamReader.ReadLine());
            }

            return stringBuilder.ToString();
        }

        public static void MakeMatrixTable(string path, int n, int m)
        {
            string[][] data = GetStringData(path, n, m);
            using (StreamWriter streamWriter = new StreamWriter("table" + path))
            {
                streamWriter.Write(" ;");
                for(int i = 1; i <= m; i++)
                {
                    streamWriter.Write(i + ";");
                }
                streamWriter.WriteLine();
                for(int i = 1; i <= n; i++)
                {
                    streamWriter.Write(i + ";");
                    for(int j = 1; j <= m; j++)
                    {
                        streamWriter.Write(data[i - 1][j - 1] + ";");
                    }
                    streamWriter.WriteLine();
                }
            }
        }

        private static string[][] GetStringData(string path, int n, int m)
        {
            string[][] data = new string[m][];
            
            using (StreamReader sR = new StreamReader(path))
            {
                sR.ReadLine();
                sR.ReadLine();
                for (int i = 1; i <= m; i++)
                {
                    string[] time = new string[n];
                    for (int j = 1; j <= n; j++)
                    {
                        string temp = sR.ReadLine();
                        if (temp != null)
                        {
                            var x = temp.Split(';');
                            time[j - 1] = x[2];
                        }
                    }

                    data[i - 1] = time;
                }
            }

                return data;
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
