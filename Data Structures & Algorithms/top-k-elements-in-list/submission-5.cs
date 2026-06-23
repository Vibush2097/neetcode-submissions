public class Solution {
    // public int[] TopKFrequent(int[] nums, int k) {
    //     Dictionary<int, int> counts = new Dictionary<int, int>();

    //     // O(n)
    //     for (int i = 0; i < nums.Length; i++) {
    //         if (!counts.ContainsKey(nums[i])) {
    //             counts[nums[i]] = 0;
    //         }
    //         counts[nums[i]]++;
    //     }

    //     PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

    //     // Insertion into Max Heap is O(log n)
    //     // To insert n elements: O(nlogn)
    //     foreach (var kvp in counts) {
    //         pq.Enqueue(kvp.Key, -kvp.Value);
    //     }

    //     int[] res = new int[k];

    //     for (int i = 0; i < k; i++) {
    //         if (pq.TryDequeue(out int key, out int value)) {
    //             res[i] = key;
    //         }
    //     }

    //     return res;
    // }

    // Solution Using BucketSort
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length + 1];
        for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        foreach (int n in nums) {
            if (count.ContainsKey(n)) {
                count[n]++;
            } else {
                count[n] = 1;
            }
        }
        foreach (var entry in count){
            freq[entry.Value].Add(entry.Key);
        }

        int[] res = new int[k];
        int index = 0;
        for (int i = freq.Length - 1; i > 0 && index < k; i--) {
            foreach (int n in freq[i]) {
                res[index++] = n;
                if (index == k) {
                    return res;
                }
            }
        }
        return res;
    }
}
