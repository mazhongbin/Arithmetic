﻿using Arithmetic.Common;
using System;

namespace Arithmetic.SortArithmetic
{
    /// <summary>
    /// 插入排序的进阶就是shell sort（希尔排序）
    /// </summary>
    /// <typeparam name="T"></typeparam>
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

        /// <summary>
        /// 对arr[left,right]进行插入排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static T[] Sort(T[] arr, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                T item = arr[i];
                int j;
                for (j = i; j > left && arr[j - 1].CompareTo(item) > 0; j--)
                    arr[j] = arr[j - 1];
                arr[j] = item;
            }
            return arr;
        }

        /// <summary>
        /// V2主要改进了交换的次数，因为交换需要开辟新的空间
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>

        public static T[] SortV2(T[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                T e = arr[i];
                int j;
                for (j = i; j > 0 && arr[j - 1].CompareTo(e) > 0; j--)
                    arr[j] = arr[j - 1];
                arr[j] = e;
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
