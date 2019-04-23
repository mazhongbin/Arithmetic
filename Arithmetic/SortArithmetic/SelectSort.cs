using Arithmetic.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetic.SortArithmetic
{
    public class SelectSort<T> where T : IComparable<T>
    {
        public static T[] Sort(T[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j].CompareTo(arr[minIndex]) < 0)
                        minIndex = j;
                }
                SortTestHelper<T>.Swap(arr, i, minIndex);
            }
            return arr;
        }

    }
}
