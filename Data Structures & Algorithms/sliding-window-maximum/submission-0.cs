public class Solution {
    Queue<int> q;
    List<int> dq;

    void Enque(int data) {
        while (dq.Count > 0 && dq[dq.Count - 1] < data) {
            dq.RemoveAt(dq.Count - 1);
        }

        dq.Add(data);
        q.Enqueue(data);
    }

    void Deque() {
        if (dq[0] == q.Peek()) {
            dq.RemoveAt(0);
        }

        q.Dequeue();
    }

    int maxQ() {
        if (dq.Count == 0)
            return -1;
        return dq[0];
    }

    public int[] MaxSlidingWindow(int[] nums, int k) {
        // // Brute force approach
        // int[] result = new int[nums.Length - k + 1];
        // int maxWindow = -1001;

        // for (int i = 0; i < (nums.Length - k + 1); i++) {
        //     maxWindow = -1001;
        //     for (int j = i; j < (i + k); j++) {
        //         maxWindow = Math.Max(maxWindow, nums[j]);
        //     }
        //     result[i] = maxWindow;
        // }

        // return result;

        int[] result = new int[nums.Length - k + 1];
        
        q = new Queue<int>();
        dq = new List<int>();

        for (int i = 0; i < k; i++) {
            Enque(nums[i]);
        }
        result[0] = maxQ();

        for (int i = 1; i < (nums.Length - k + 1); i++) {
            Deque();
            Enque(nums[i + k - 1]);
            result[i] = maxQ();
        }

        return result;
    }
}
