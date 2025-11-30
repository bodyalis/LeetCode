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

        var freq = new TopKFrequentElements().TopKFrequent([1, 1, 2, 2, 3], 2);
    }
}