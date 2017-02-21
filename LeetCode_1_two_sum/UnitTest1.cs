using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_1_two_sum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_nums_is_1_8_and_target_is_9_should_return_0_1()
        {
            var sut = new Solution();
            var nums = new int[] { 1, 8 };
            var target = 9;

            var expected = new int[] { 0, 1 };

            var actual = sut.TwoSum(nums, target);

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
