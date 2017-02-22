using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

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
            var sorted = nums
                .Select((x, index) => Tuple.Create(x, index))
                .OrderBy(x => x.Item1).ToArray();

            var start = 0;
            var end = sorted.Length - 1;
            while (start < end)
            {
                if (sorted[start].Item1 + sorted[end].Item1 == target)
                {
                    return new int[] { Math.Min(sorted[start].Item2, sorted[end].Item2), Math.Max(sorted[start].Item2, sorted[end].Item2) };
                }
                else if (sorted[start].Item1 + sorted[end].Item1 < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return null;
        }
    }
}