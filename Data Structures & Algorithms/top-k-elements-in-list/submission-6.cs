public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!dict.ContainsKey(num)) {
                dict[num] = 0;
            }
            dict[num]++;
        }

        foreach (var kvp in dict) {
            maxHeap.Enqueue(kvp.Key, kvp.Value);

            if (maxHeap.Count > k) {
                maxHeap.Dequeue();
            }
        }

        int[] result = new int[k];
        int i = 0;

        while (maxHeap.Count > 0) {
            result[i++] = maxHeap.Dequeue();
        }

        return result;
    }
}

/*
1: 5
2: 4
3: 6
4: 3

k = 2

Heap: 1 -> 3
*/