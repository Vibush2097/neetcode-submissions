public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> nums = new Stack<int>();

        for (int i = 0; i < tokens.Length; i++) {
            bool success = int.TryParse(tokens[i], out int number);
            if (success) {
                nums.Push(number);
            }
            else {
                int num2 = nums.Pop();
                int num1 = nums.Pop();
                int result = Operation(num1, num2, tokens[i]);
                nums.Push(result);
            }
        }

        return nums.Pop();
    }

    private int Operation(int num1, int num2, string operand) {
        switch(operand) {
            case "+":
                return num1 + num2;

            case "-":
                return num1 - num2;

            case "*":
                return num1 * num2;

            case "/":
                return num1 / num2;

            default:
                return 0;
        }
    }
}
