namespace LeetCode.Problems.Arrays._347._Top_K_Frequent_Elements;

public class TopKFrequentElements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return nums;
        }

        Dictionary<int, int> dict = new();
        foreach (int num in nums)
        {
            if (!dict.TryAdd(num, 1))
            {
                dict[num]++;
            }
        }

        PriorityQueue<int, int> pg = new(dict.Count, Comparer<int>.Create((x, y) => y.CompareTo(x)));

        IEnumerable<(int Element, int Priority)> kc = dict.Select(kv => (kv.Key, kv.Value));
        pg.EnqueueRange(kc);

        int[] res = new int[k];
        for (int i = 0; i < k; i++)
        {
            res[i] = pg.Dequeue();
        }

        return res;
    }
}