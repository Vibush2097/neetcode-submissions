public class KthLargest {
    PriorityQueue<int, int> maxHeap;
    int _k;

    public KthLargest(int k, int[] nums) {
        _k = k;
        maxHeap = new PriorityQueue<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            maxHeap.Enqueue(nums[i], nums[i]);
        }

        while (maxHeap.Count > k) {
            maxHeap.Dequeue();
        }
    }
    
    public int Add(int val) {
        maxHeap.Enqueue(val, val);

        if (maxHeap.Count > _k) {
            maxHeap.Dequeue();
        }

        return maxHeap.Peek();
    }
}
