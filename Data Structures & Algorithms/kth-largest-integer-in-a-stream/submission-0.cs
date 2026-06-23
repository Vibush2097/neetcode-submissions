public class KthLargest {
    PriorityQueue<int, int> pq;
    int capacity;

    public KthLargest(int k, int[] nums) {
        capacity = k;
        pq = new PriorityQueue<int, int>();

        foreach (var num in nums) {
            pq.Enqueue(num, num);

            if (pq.Count > k) {
                pq.Dequeue();
            }
        }    
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);

        if (pq.Count > capacity) {
            pq.Dequeue();
        }

        return pq.Peek();
    }
}
