public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in tasks) {
            if (!dict.ContainsKey(c)) {
                dict[c] = 1;
            }
            else {
                dict[c]++;
            }
        }

        PriorityQueue<char, int> maxHeap = new PriorityQueue<char, int>();
        Dictionary<char, int> lastSeen = new Dictionary<char, int>();

        foreach (var kvp in dict) {
            maxHeap.Enqueue(kvp.Key, -kvp.Value);
            lastSeen[kvp.Key] = -n;
        }

        Queue<(char, int)> cooldown = new Queue<(char, int)>();

        int time = 0;

        while (maxHeap.Count > 0 || cooldown.Count > 0) {
            if (cooldown.Count > 0 && time > (lastSeen[cooldown.Peek().Item1] + n)) {
                var front = cooldown.Dequeue();
                maxHeap.Enqueue(front.Item1, -front.Item2);
            }
            if (maxHeap.Count > 0) {
                maxHeap.TryDequeue(out char cur, out int priority);
                lastSeen[cur] = time;
                int remaining = (int) Math.Abs(priority) - 1;

                if (remaining > 0) {
                    cooldown.Enqueue((cur, remaining));
                }
            }
            time++;
        }

        return time;
    }
}
