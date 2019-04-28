using Arithmetic.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetic.SortArithmetic
{
    /// <summary>
    /// 对于完全有序的数列，快速排序会退化为O(n^2)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QuickSort<T> where T : IComparable<T>
    {
        private static Random _random;

        static QuickSort()
        {
            _random = new Random();
        }

        public static T[] Sort(T[] arr, int n)
        {
            QuickReSort(arr, 0, n - 1);

            return arr;
        }

        /// <summary>
        /// 对数组从[l,r]进行快速排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        private static void QuickReSort(T[] arr, int l, int r)
        {
            //if (l >= r)
            //    return;
            if (r - l < 15)
            {
                InsertSort<T>.Sort(arr, l, r);
                return;
            }

            int p = Partition(arr, l, r);
            QuickReSort(arr, l, p - 1);
            QuickReSort(arr, p + 1, r);
        }

        /// <summary>
        /// 对arr[l,r]部分进行Partition操作
        /// 返回索引p,是的arr[l,p-1]<arr[p]<arr[p+1,r]
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private static int Partition(T[] arr, int left, int right)
        {
            //防止退化为O(n^2)的优化点。
            T v = arr[_random.Next() % (right - left + 1) + left];
            //T v = arr[left];
            int j = left;
            for (int i = left + 1; i <= right; i++)
            {
                if (arr[i].CompareTo(v) < 0)
                {
                    SortTestHelper<T>.Swap(arr, j + 1, i);
                    j++;
                }
            }
            SortTestHelper<T>.Swap(arr, left, j);
            return j;
        }
    }
}
