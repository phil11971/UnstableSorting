using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[] { 9, 6, 10, 8, 43, 2, 6, 24, 6 };

            Console.WriteLine("Src mas");
            PrintMas(mas);

            mas = ShellSort(mas);

            Console.WriteLine("Res mas");
            PrintMas(mas);

            Console.ReadKey();
        }

        //Cложность O(n^(4/3)) или O(n*log^2(n))
        static int[] ShellSort(int[] arr)
        {
            int increment = arr.Length / 2;
            while (increment >= 1)
            {
                for (int startIndex = 0; startIndex < increment; startIndex++)
                {
                    InsertionSort(arr, startIndex, increment);
                }
                increment = increment / 2;
            }
            return arr;
        }

        private static void InsertionSort(int[] arr, int startIndex, int increment)
        {
            for (int i = startIndex; i < arr.Length - 1; i = i + increment)
            {
                for (int j = Math.Min(i + increment, arr.Length - 1); j - increment >= 0; j = j - increment)
                {
                    if (arr[j - increment] > arr[j])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j - increment];
                        arr[j - increment] = tmp;
                    }
                    else break;
                }
            }
        }

        static void PrintMas(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
