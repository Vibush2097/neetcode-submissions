public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));
        pq.Enqueue(stones[0], stones[0]);

        for (int i = 1; i < stones.Length; i++) {
            pq.Enqueue(stones[i], stones[i]);
        }

        while (pq.Count > 1) {
            int stone1 = pq.Dequeue();
            int stone2 = pq.Dequeue();
            int diff = Math.Abs(stone1 - stone2);

            if (diff > 0) {
                pq.Enqueue(diff, diff);
            }
        }

        return pq.Count > 0 ? pq.Dequeue() : 0;
    }
}
