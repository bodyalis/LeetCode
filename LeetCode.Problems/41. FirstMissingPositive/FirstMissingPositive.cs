namespace LeetCode.Problems._41._FirstMissingPositive;

public class FirstMissingPositive
{
    public int Solution(int[] nums)
    {
        int length = nums.Length;

        bool[] exists = new bool[length+1];

        for (int i = 0; i < length; i++)
        {
            int num = nums[i];
            if (num > 0 && num <= length) exists[num] = true; 
        }

        for (int i = 1; i < length + 1; i++)
        {
            if (!exists[i]) return i;
        }

        return exists.Length;
    }
}
