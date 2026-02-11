using System.ComponentModel;

namespace LeetCode.Problems._42._Trapping_Rain_Water;

public class TrappingRainWater
{
    public int Trap(int[] height)
    {
        if (height.Length == 0)
        {
            return 0;
        }

        int[] leftMax = new int[height.Length];
        int[] rightMax = new int[height.Length];

        leftMax[0] = height[0];
        for (int i = 1; i < height.Length; i++)
        {
            leftMax[i] = int.Max(leftMax[i - 1], height[i]);
        }

        rightMax[height.Length - 1] = height[^1];
        for (int i = height.Length - 2; i > 0; i--)
        {
            rightMax[i] = int.Max(rightMax[i + 1], height[i]);
        }

        int max = 0;
        for (int i = 1; i < height.Length; i++)
        {
            int waterLevel = Math.Min(leftMax[i], rightMax[i]); // The water level at index i
            max += waterLevel - height[i]; // Water trapped above current bar
        }

        return max;
    }

    public int Trap2(int[] height)
    {
        int left = 0, right = height.Length - 1;
        int sum = 0;
        int leftMax = 0;
        int rightMax = 0;
        while (left < right)
        {
            int currLeft = height[left], currRight = height[right];
            if (currLeft < currRight)
            {
                left++;
                leftMax = Math.Max(leftMax, currLeft);
                sum += leftMax - currLeft;
            }
            else
            {
                right--;
                rightMax = Math.Max(rightMax, currRight);
                sum += rightMax - currRight;
            }
        }
        
        return sum;
    }
}
