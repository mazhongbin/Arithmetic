using System;
using System.Diagnostics;

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

        public static int Search(T[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (key.CompareTo(arr[middle]) < 0)
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return left;
        }

        public static int SearchRecursion(T[] arr, int left, int right, T key)
        {
            if (right < left)
                return left;
            int mid = left + (right - left) / 2;
            if (arr[mid].CompareTo(key) < 0)
                return SearchRecursion(arr, mid + 1, right, key);
            else
                return SearchRecursion(arr, left, mid - 1, key);
        }
    }
}
