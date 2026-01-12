using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Q0347.TopKFrequentElements;

public static class Solution
{
    public static int[] TopKFrequent_PriorityQueue(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            freq[num] = freq.TryGetValue(num, out var count) ? count + 1 : 1;
        }
        
        var pq = new PriorityQueue<int, int>();

        foreach (var (value, count) in freq)
        {
            pq.Enqueue(value, count);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        var ans = new int[k];
        for (var i = k - 1; i >= 0; i--)
        {
            ans[i] = pq.Dequeue();
        }

        return ans;
    }
    
    public static int[] TopKFrequent_BucketsSort(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            freq[n] = freq.TryGetValue(n, out var c) ? c + 1 : 1;
        }
        
        var buckets = new List<int>?[nums.Length + 1];
        foreach (var (num, count) in freq)
        {
            buckets[count] ??= [];

            buckets[count]!.Add(num);
        }
        
        var result = new List<int>();
        for (var i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
            {
                result.AddRange(buckets[i]!);
            }
        }

        return result.Take(k).ToArray();
    }
}