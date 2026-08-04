public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] numCounts = new int[2001];

        for (int i = 0; i < nums.Length; i++) {
            numCounts[nums[i] + 1000]++;
        }

        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

        for (int i = -1000; i <= 1000; i++) {
            maxHeap.Enqueue(i, numCounts[1000 + i]);

            if (maxHeap.Count > k) {
                maxHeap.Dequeue();
            }
        }

        int[] result = new int[k];
        int index = 0;

        while (maxHeap.Count > 0)
        {
            result[index++] = maxHeap.Dequeue();
        }

        return result;
    }
}
