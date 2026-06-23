public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        int val1, val2;

        for (int i = 0; i < tokens.Length; i++) {
            if (tokens[i].Equals("+")) {
                val1 = stack.Pop();
                val2 = stack.Pop();
                stack.Push(val2 + val1);
            }
            else if (tokens[i].Equals("-")) {
                val1 = stack.Pop();
                val2 = stack.Pop();
                stack.Push(val2 - val1);
            }
            else if (tokens[i].Equals("*")) {
                val1 = stack.Pop();
                val2 = stack.Pop();
                stack.Push(val2 * val1);
            }
            else if (tokens[i].Equals("/")) {
                val1 = stack.Pop();
                val2 = stack.Pop();
                stack.Push(val2 / val1);
            }
            else {
                int n = int.Parse(tokens[i]);
                stack.Push(n);
            }
        }

        return stack.Pop();
    }
}
