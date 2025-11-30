namespace LeetCode.Problems.Arrays;

public partial class ArraysSolution
{
    public int RemoveDuplicates(int[] nums)
    {
        int pos = 1;
        int previous = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (previous != nums[i])
            {
                nums[pos] = nums[i];
                pos++;
            }

            previous = nums[i];
        }

        return pos;
    }
}