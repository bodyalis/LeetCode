using LeetCode.Problems._41._FirstMissingPositive;
using LeetCode.Problems._42._Trapping_Rain_Water;
using LeetCode.Problems._7._Reverse_Integer;
using LeetCode.Problems.Arrays._347._Top_K_Frequent_Elements;

internal class Program
{
    public static void Main()
    {
        // string s1 = "aa";
        // string s2 = "bb";
        //
        // Console.WriteLine(ValidAnagram.IsAnagram(s1, s2));

        // IList<IList<string>> list = GroupAnagram.GroupAnagrams2(["bdddddddddd", "bdddddddddd"]);

        // var freq = new TopKFrequentElements().TopKFrequent([1, 1, 2, 2, 3], 2);
        //
        // var vater = new TrappingRainWater().Trap2([ 0,1,0,2,1,0,1,3,2,1,2,1 ]);
        // Console.WriteLine(vater);
        
        // var reversed = new ReverseInteger().Reverse(-1999999999);
        // Console.WriteLine(reversed);
        
        var missingPositive = new FirstMissingPositive().Solution([1]);
        Console.WriteLine(missingPositive);
    }
}