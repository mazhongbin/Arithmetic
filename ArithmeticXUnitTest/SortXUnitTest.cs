using Arithmetic.Common;
using Xunit;

namespace ArithmeticXUnitTest
{
    public class SortXUnitTest
    {
        [Fact]
        public void SearchTest()
        {
            int[] arr = new int[] { 1, 3, 5, 8, 9, 14, 19 };
            int key = 13;
            var result = SortTestHelper<int>.Search(arr, key);
            Assert.Equal<int>(5, result);
        }
    }
}
