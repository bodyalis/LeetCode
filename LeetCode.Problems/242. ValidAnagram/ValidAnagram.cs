namespace LeetCode.Problems.Arrays._242._ValidAnagram;

public class ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        if (s.Length == 0)
            return true;

        int[] arr = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            int sIdx = s[i] - 'a';
            int tIdx = t[i] - 'a';
            arr[sIdx]++;
            arr[tIdx]--;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
                return false;
        }

        return true;
    }
}