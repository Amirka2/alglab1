using System;
using System.IO;
using System.Text;

namespace algorithm_lab1
{
    public static class Helper
    {
        static public void saveData(string path, string data)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(data);
            }
        }

        static public string getData(string path)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.ReadLine() != null)
                {
                    sb.Append(sr.ReadLine());
                }
            }
            return sb.ToString();
        }

        static public void deleteData(string path)
        {
            File.Delete(path);
        }

        static public void deleteData(string[] paths)
        {
            for (int i = 0; i < paths.Length; i++)
            {
                File.Delete(paths[i]);
            }
        }

        static public int[,] formatXandY(string data)
        {
            string[] strArray = data.Split(" ");
            int rows = strArray.Length / 2;
            int[,] coordinates = new int[2, rows];
            for(int i = 0; i < rows; i++) {
                coordinates[0, i] = i;
                coordinates[1, i] = i* 2;
            }

        return coordinates;
    }

        static public void makeMeasure(Sort sort, String path)
        {
            //Instant start = Instant.now();
            //int[] sortedArray = sort.sort();
            //Instant end = Instant.now();
            //Duration d = Duration.between(start, end);
            //Helper.saveData(path, sort.array.length, d);
        }

        public static int[] getRandomArray(int length)
        {
            int[] arr = new int[length];
            Random rnd = new Random();
            int i = 0;

            while (i < length)
            {
                arr[i] = rnd.Next(0, 100);
                i++;
            }

            return arr;
        }

        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
