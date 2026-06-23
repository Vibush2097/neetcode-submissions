public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> nums = new Stack<int>();
        int numericValue;

        for (int i=0; i<tokens.Length; i++) {
            bool isNumber = int.TryParse(tokens[i], out numericValue);
            if (isNumber) {
                nums.Push(numericValue);
            }
            else {
                var second = nums.Pop();
                var first = nums.Pop();

                if (tokens[i] == "+")
                    nums.Push(first + second);

                else if (tokens[i] == "-")
                    nums.Push(first - second);

                else if (tokens[i] == "*")
                    nums.Push(first * second);

                else if (tokens[i] == "/")
                    nums.Push(first / second);
            }
        }

        return nums.Pop();
    }
}
