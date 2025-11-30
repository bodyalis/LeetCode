namespace LeetCode.Problems.Arrays._42._Group_Anagrams;

public class GroupAnagram
{
    public static IList<IList<string>> GroupAnagrams(string[] str)
    {
        bool[] visited = new bool[str.Length];
        IList<string>[] list = new IList<string>[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            if (visited[i])
            {
                continue;
            }

            string s1 = str[i];
            visited[i] = true;
            list[i] = new List<string>() { s1 };

            for (int j = i + 1; j < str.Length; j++)
            {
                if (visited[j])
                {
                    continue;
                }

                string s2 = str[j];

                if (IsAnagram(s1, s2))
                {
                    list[i].Add(s2);
                    visited[j] = true;
                }
            }
        }

        return list.Where(_ => true).ToList();
    }

    public static IList<IList<string>> GroupAnagrams2(string[] str)
    {
        Dictionary<string, IList<string>> res = new();
        foreach (string s in str)
        {
            int[] cnt = new int[26];
            foreach (char c in s)
            {
                int idx = c - 'a';
                cnt[idx]++;
            }

            string key = string.Join(",", cnt);
            if (!res.ContainsKey(key))
            {
                res.Add(key, new List<string>());
            }

            res[key].Add(s);
        }

        return res.Values.ToList();
    }


    private static bool IsAnagram(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        if (s1.Length == 0)
        {
            return true;
        }

        int[] arr = new int[26];
        for (int i = 0; i < s1.Length; i++)
        {
            int s1Idx = s1[i] - 'a';
            int s2Idx = s2[i] - 'a';

            arr[s1Idx]++;
            arr[s2Idx]--;
        }

        foreach (int i in arr)
        {
            if (i != 0)
            {
                return false;
            }
        }

        return true;
    }
}