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
        static void QuickSort(ref int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2,
            //но не вызввает переполнения на больших данных
            int i = l;
            int j = r;
            //код в while обычно выносят в процедуру particle
            while (i <= j)
            {
                while (a[i] < x)
                    i++;

                while (a[j] > x)
                    j--;

                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp; i++;
                    j--;
                }
            }
            if (i < r) QuickSort(ref a, i, r);
            if (l < j) QuickSort(ref a, l, j);
        }

        static void PrintMas(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
