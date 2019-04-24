using Arithmetic.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticUnitTest
{
    [TestClass]
    public class SortArithmeticUnitTest
    {
        [TestMethod]
        public void SearchTest()
        {
            int[] arr = new int[] { 1, 3, 3, 13, 13, 14, 19 };
            int key = 20;
            var result = SortTestHelper<int>.SearchRecursion(arr, 0, 6, key);
            Assert.AreEqual<int>(7, result);
        }
    }
}
