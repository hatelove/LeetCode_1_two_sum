using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod]
        public void Test_nums_is_1_2_4_and_target_is_5_should_return_0_2()
        {
            var nums = new int[] { 1, 2, 4 };
            var actual = TwoSum(nums, 5);

            var expected = new int[] { 0, 2 };
            ShouldEqual(expected, actual);
        }

        [TestMethod]
        public void Test_nums_is_4_2_1_and_target_is_5_should_return_0_2()
        {
            var nums = new int[] { 4, 2, 1 };
            var actual = TwoSum(nums, 5);

            var expected = new int[] { 0, 2 };
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
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var key = target - nums[i];
                if (dictionary.ContainsKey(key) && dictionary[key] != i)
                {
                    return new int[] { dictionary[key], i };
                }
                else if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}