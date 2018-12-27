using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoogeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[] { 9, 6, 10, 8, 43, 2, 6, 24, 6 };

            Console.WriteLine("Src mas");
            PrintMas(mas);

            Stoogesort(ref mas, 0, mas.Length - 1);

            Console.WriteLine("Res mas");
            PrintMas(mas);

            Console.ReadKey();
        }

        static void Stoogesort(ref int[] arr, int l, int h)
        {
            if (l >= h)
                return;

            if (arr[l] > arr[h])
            {
                int t = arr[l];
                arr[l] = arr[h];
                arr[h] = t;
            }

            if (h - l + 1 > 2)
            {
                int t = (h - l + 1) / 3;

                Stoogesort(ref arr, l, h - t);
                Stoogesort(ref arr, l + t, h);
                Stoogesort(ref arr, l, h - t);
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
