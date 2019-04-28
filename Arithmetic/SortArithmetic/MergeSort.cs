using System;

namespace Arithmetic.SortArithmetic
{
    public class MergeSort<T> where T : IComparable<T>
    {
        public static T[] Sort(T[] arr, int n)
        {
            MergeReSort(arr, 0, n - 1);
            return arr;
        }

        public static T[] SortBU(T[] arr, int n)
        {
            for (int sz = 1; sz < n; sz += sz)
            {
                for (int i = 0; i + sz < n; i += 2 * sz)
                    Merge(arr, i, i + sz - 1, Min(i + sz + sz - 1, n - 1));
            }
            return arr;
        }

        private static int Min(int n1, int n2)
        {
            return n1 > n2 ? n2 : n1;
        }

        /// <summary>
        /// 递归的归并排序 [left,right]区间的排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left">坐区间</param>
        /// <param name="right">右区间</param>
        private static void MergeReSort(T[] arr, int left, int right)
        {
            if (right - left <= 15)//优化点2,，当数据量较少时，进行插入排序，因为数据量较少，有序的可能性也较大。
            {
                InsertSort<T>.Sort(arr, left, right);
                return;
            }

            int mid = left + (right - left) / 2;
            MergeReSort(arr, left, mid);
            MergeReSort(arr, mid + 1, right);
            if (arr[mid].CompareTo(arr[mid + 1]) > 0)//优化点1
                Merge(arr, left, mid, right);
        }

        /// <summary>
        /// 将arr[left,mid]和[mid,right]进行归并排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="mid"></param>
        /// <param name="right"></param>
        private static void Merge(T[] arr, int left, int mid, int right)
        {
            T[] tempArr = new T[right - left + 1];
            for (int i = left; i <= right; i++)
                tempArr[i - left] = arr[i];
            int m = left;
            int n = mid + 1;
            for (int k = left; k <= right; k++)
            {
                if (m > mid)
                {
                    arr[k] = tempArr[n - left];
                    n++;
                }
                else if (n > right)
                {
                    arr[k] = tempArr[m - left];
                    m++;
                }
                else if (tempArr[m - left].CompareTo(tempArr[n - left]) < 0)
                {
                    arr[k] = tempArr[m - left];
                    m++;
                }
                else
                {
                    arr[k] = tempArr[n - left];
                    n++;
                }
            }
        }
    }
}
