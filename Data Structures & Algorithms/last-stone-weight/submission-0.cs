public class Solution {
    public int LastStoneWeight(int[] stones) {
        // Change to a max-heap instead of min-heap
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach (var num in stones) {
            maxHeap.Enqueue(num, num);
        }

        while (maxHeap.Count > 1) {
            int stone1 = maxHeap.Dequeue();
            int stone2 = maxHeap.Dequeue();
            int diff = Math.Abs(stone1 - stone2);

            // Console.WriteLine($"stone1: {stone1} \t stone2: {stone2} \t diff: {diff}");
            
            if (diff > 0) {
                maxHeap.Enqueue(diff, diff);
            }
        }

        return maxHeap.Count > 0 ? maxHeap.Dequeue() : 0;
    }
}
