using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[] { 9, 6, 10, 8, 43, 2, 6, 24, 6 };

            Console.WriteLine("Src mas");
            PrintMas(mas);

            QuickSort(ref mas, 0, mas.Length - 1);

            Console.WriteLine("Res mas");
            PrintMas(mas);

            Console.ReadKey();
        }

        //Сложность алгоритма: 
        //O(n*logn) - ср. время
        //O(n^2) - худший случай
        static void QuickSort(ref int[] arr, int l, int r)
        {
            int tmp;
            int midEl = arr[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2,
            //но не вызввает переполнения на больших данных
            int i = l;
            int j = r;
            //код в while обычно выносят в процедуру particle
            while (i <= j)
            {
                while (arr[i] < midEl)
                    i++;

                while (arr[j] > midEl)
                    j--;

                if (i <= j)
                {
                    tmp = arr[i];
                    arr[i++] = arr[j];
                    arr[j--] = tmp; 
                }
            }
            if (i < r) QuickSort(ref arr, i, r);
            if (l < j) QuickSort(ref arr, l, j);
        }

        static void PrintMas(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
