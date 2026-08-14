public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        List<int[]> pairs = new List<int[]>();

        for (int i = 0; i < position.Length; i++) {
            pairs.Add(new int[] { position[i], speed[i]});
        }

        var sortedPairs = pairs.OrderByDescending(arr => arr[0]).ToList();

        Stack<double> stack = new Stack<double>();

        for (int i = 0; i < sortedPairs.Count; i++) {
            int pos = sortedPairs[i][0];
            int spd = sortedPairs[i][1];
            double timeToTarget = (double)(target - pos) / spd;

            if (stack.Count == 0 || stack.Peek() < timeToTarget) {
                stack.Push(timeToTarget);
            }
        }

        return stack.Count;
    }
}
