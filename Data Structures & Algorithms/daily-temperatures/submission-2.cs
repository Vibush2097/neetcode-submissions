public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<int[]> temps = new Stack<int[]>();

        for (int i = 0; i < temperatures.Length; i++) {
            if (temps.Count == 0 || temperatures[i] < temps.Peek()[0]) {
                temps.Push(new int[] {temperatures[i], i});
            }
            else {
                int pos;
                while (temps.Count > 0 && temperatures[i] > temps.Peek()[0]) {
                    var top = temps.Pop();
                    result[top[1]] = i - top[1];
                }
                temps.Push(new int[] {temperatures[i], i});
            }
        }

        while (temps.Count > 0) {
            var top = temps.Pop();
            result[top[1]] = 0;
        }

        return result;
    }
}
