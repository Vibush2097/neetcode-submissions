public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        Dictionary<int, int> counts = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (!counts.ContainsKey(nums[i])) {
                counts[nums[i]] = 0;
            }
            counts[nums[i]]++;
        }

        foreach (var kvp in counts) {
            pq.Enqueue(kvp.Key, kvp.Value);

            if (pq.Count > k) {
                pq.Dequeue();
            }
        }

        int[] result = new int[k];
        int idx = 0;

        while (k > 0) {
            int top = pq.Dequeue();
            result[idx++] = top;
            --k;
        }

        return result;
    }
}
