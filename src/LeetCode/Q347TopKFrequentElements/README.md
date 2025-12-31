# LeetCode 347. TopKFrequentElements

## Problem
https://leetcode.com/problems/top-k-frequent-elements/

## Solution

To solve this problem, what we need to think are followings
- Count the frequency of each value in the array
- Extract the k items in descending order of frequency

To count the frequency, you can use `Dictionary`.
```csharp
var freq = new Dictionary<int, int>();
foreach (var num in nums)
{
    freq[num] = freq.TryGetValue(num, out var count) ? count + 1 : 1;
}
```

After that, we can think about multiple ways to extract the k items.

### Priority Queue

Prepare a min-heap to store `(value, count)`, with a maximum size of k.
Insert elements into the heap one by one.
If the heap size exceeds k, remove the smallest element.
After processing all elements, the heap contains the top k most frequent elements.

```csharp
public static class Solution
{
    public static int[] TopKFrequent_PriorityQueue(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        foreach (var x in nums)
        {
            freq[x] = freq.TryGetValue(x, out var c) ? c + 1 : 1;
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
}
```

#### Time Complexity `O(n + m log k)`

Counting frequencies: `O(n)`

Heap operations: for m unique elements, each heap operation costs `O(log k)`
→ `O(m log k)`

Total: `O(n + m log k)`

#### Space complexity `O(m + k)`
- Frequency map (Dictionary)
    - Stores the frequency of each unique element
→ `O(m)` where m is the number of unique elements

- Min-heap
    - Stores at most k elements
→ `O(k)`

### Bucket Sort
Frequency will be
- Minimum Frequency: 1
- Maximum Frequency: `nums.Length = n` (if all values are same, frequency will be n)

If we want to sort with frequency, we can use it for index of an array instead of sorting.
```csharp
var buckets = new List<int>?[nums.Length + 1];
buckets[frequency] = the values which has the frequency;
```

```text
(Example)
nums = [1,1,1,2,2,2,3]

frequency:
1 -> 3
2 -> 3
3 -> 1

buckets:
index 0: -
index 1: [3]
index 2: -
index 3: [1, 2]
```

After that, we get the k elements from the buckets.

```csharp
public static class Solution
{
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
```