// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order
//https://leetcode.com/problems/two-sum/


// Brute Force This
//Pretty basic approach
//Consider the first, consider the traget - first and see if a second number exists

namespace leetcode.array_problems
{
    public class TwoSumProblem
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            //return new int[]{};
            return new ArgumentException("no solution exists.");
        }

        public int[] TwoSumV2(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                return new ArgumentException("no solution exists.");
            }

            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

                if (dic.ContainsKey(target - nums[i]))
                    return new int[] { i, dic[target - nums[i]] };
                else
                    dic.TryAdd(nums[i], i);
            }

            return new ArgumentException("no solution exists.");
        }
    }
}
