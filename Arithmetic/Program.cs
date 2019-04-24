using Arithmetic.Common;
using Arithmetic.SortArithmetic;
using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 50000;
            int[] arr = SortTestHelper<int>.GenerateRandomArray(n, 0, n);

            //SortTestHelper<int>.TestSort(nameof(SelectSort<int>), (arr, n) => { SelectSort<int>.Sort(arr, n); }, arr, n);

            //SortTestHelper<int>.TestSort(nameof(BobbleSort<int>), (arr, n) => { BobbleSort<int>.Sort(arr, n); }, arr, n);

            //SortTestHelper<int>.TestSort(nameof(BobbleSort<int>), (arr, n) => { BobbleSort<int>.CocktailSort(arr, n); }, arr, n);

            SortTestHelper<int>.TestSort(nameof(InsertSort<int>), (arr, n) => { InsertSort<int>.Sort(arr, n); }, arr, n);

            SortTestHelper<int>.TestSort(nameof(InsertSort<int>), (arr, n) => { InsertSort<int>.SortDichotomy(arr, n); }, arr, n);



            #region Other Class Sort
            //var stu = new Student[]
            //{
            //   new Student
            //   {
            //        Name = "aa",
            //        Score = 92
            //   },
            //   new Student
            //   {
            //        Name = "ma1",
            //        Score = 97
            //   },
            //   new Student
            //   {
            //        Name = "ga2",
            //        Score = 90
            //   },

            //};

            //var newStu = SelectSort<Student>.Sort(stu, 3);
            //SortTestHelper<Student>.PrintArray(newStu, 3); 
            #endregion

            Console.ReadKey();
        }
    }
}
