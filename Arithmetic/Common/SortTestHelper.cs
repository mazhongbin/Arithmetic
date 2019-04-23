using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Arithmetic.Common
{
    public class SortTestHelper<T> where T : IComparable<T>
    {
        public static int[] GenerateRandomArray(int n, int rangeL, int rangeR)
        {
            if (rangeR < rangeL)
                throw new Exception("rangeR cann't smaller than rangeL");
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = random.Next(rangeR - rangeL) + rangeL;
            return arr;
        }

        public static void PrintArray(T[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i]);
        }

        public static void Swap(T[] arr, int m, int n)
        {
            T temp = arr[m];
            arr[m] = arr[n];
            arr[n] = temp;
        }

        public static bool IsSorted(T[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                    return false;
            }
            return true;
        }

        public static void TestSort(string sortName, Action<T[], int> action, T[] arr, int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action(arr, n);
            stopwatch.Stop();

            if (!IsSorted(arr, n))
            {
                Console.WriteLine("Array is not Sort!");
                return;
            }

            Console.WriteLine($"Arithmetic:{sortName},UseTime:{stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
