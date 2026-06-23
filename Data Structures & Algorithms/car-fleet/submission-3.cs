public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] pair = new int[position.Length][];

        for (int i = 0; i < position.Length; i++) {
            pair[i] = new int[] { position[i], speed[i] };
        }

        // Sort the positions and speed in descending order
        Array.Sort(pair, (a,b) => b[0].CompareTo(a[0]));
        Stack<double> stack = new Stack<double>();

        // We push elements onto the stack. For any new element, if the 
        // arrival time in the destination is earlier than the one before
        // we know it has to match the speed of the before value. Hence we 
        // delete the earlier arrival time from the stack
        foreach (var p in pair) {
            stack.Push((double)(target - p[0]) / p[1]);
            if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)) {
                stack.Pop();
            }
        }

        // The stack count gives us the number of fleets
        return stack.Count;
    }
}
