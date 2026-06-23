public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (!counts.ContainsKey(nums[i])) {
                counts[nums[i]] = 0;
            }
            counts[nums[i]]++;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        foreach (var kvp in counts) {
            pq.Enqueue(kvp.Key, -kvp.Value);
        }

        int[] res = new int[k];

        for (int i = 0; i < k; i++) {
            if (pq.TryDequeue(out int key, out int value)) {
                res[i] = key;
            }
        }

        return res;
    }
}
