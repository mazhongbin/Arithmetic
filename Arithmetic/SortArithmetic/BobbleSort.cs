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
    }
}
