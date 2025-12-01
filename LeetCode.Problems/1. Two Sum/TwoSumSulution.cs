namespace LeetCode.Problems.Arrays;

public partial class ArraysSolution
{
    // public int[] TwoSum(int[] nums, int target)
    // {
    //     for (int i = 0; i < nums.Length - 1; i++)
    //     {
    //         for (int j = i + 1; j < nums.Length; j++)
    //         {
    //             if (nums[i] + nums[j] == target)
    //             {
    //                 return new[] { i, j };
    //             }
    //         }
    //     }
    //
    //     return null;
    // }

    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            int val = nums[i];
            if (dict.ContainsKey(target - val))
            {
                return new int[] { dict[target - val], i };
            }

            if (!dict.ContainsKey(val))
            {
                dict.Add(val, i);
            }
        }

        return null;
    }
}