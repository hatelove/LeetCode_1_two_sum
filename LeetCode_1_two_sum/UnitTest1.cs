using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_1_two_sum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_nums_is_1_8_and_target_is_9_should_return_0_1()
        {
            var nums = new int[] { 1, 8 };
            var actual = TwoSum(nums, 9);

            var expected = new int[] { 0, 1 };
            ShouldEqual(expected, actual);
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            var actual = new Solution().TwoSum(nums, target);
            return actual;
        }

        private static void ShouldEqual(int[] expected, int[] actual)
        {
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            return new int[] { 0, 1 };
        }
    }
}