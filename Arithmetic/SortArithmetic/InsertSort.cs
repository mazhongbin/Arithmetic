using Arithmetic.Common;
using System;

namespace Arithmetic.SortArithmetic
{
    public class InsertSort<T> where T : IComparable<T>
    {
        public static T[] Sort(T[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j].CompareTo(arr[j - 1]) < 0)
                        SortTestHelper<T>.Swap(arr, j, j - 1);
                    else
                        break;
                }
            }
            return arr;
        }
    }
}
