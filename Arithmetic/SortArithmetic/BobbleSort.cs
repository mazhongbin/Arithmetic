using Arithmetic.Common;
using System;

namespace Arithmetic.SortArithmetic
{
    public class BobbleSort<T> where T : IComparable<T>
    {
        public static T[] Sort(T[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                        SortTestHelper<T>.Swap(arr, i, j);
                }
            }
            return arr;
        }

        public static T[] CocktailSort(T[] arr, int n)
        {
            int left = 0;
            int right = n - 1;
            while (left < right)
            {
                for (int i = left; i <= right; i++)
                {
                    if (arr[left].CompareTo(arr[i]) > 0)
                        SortTestHelper<T>.Swap(arr, left, i);
                }
                left++;
                for (int i = right; i > left; i--)
                {
                    if (arr[right].CompareTo(arr[i]) < 0)
                        SortTestHelper<T>.Swap(arr, right, i);
                }
                right--;
            }
            return arr;
        }
    }
}
