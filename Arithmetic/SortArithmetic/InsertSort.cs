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

        public static T[] SortDichotomy(T[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int left = 0;
                int right = i - 1;
                T getItem = arr[i];

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (getItem.CompareTo(arr[mid]) < 0)
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                for (int j = i - 1; j >= left; j--)
                    arr[j + 1] = arr[j];
                arr[left] = getItem;
            }
            return arr;
        }
    }
}
