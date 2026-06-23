public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> dict = new Dictionary<char, char>();

        dict[')'] = '(';
        dict['}'] = '{';
        dict[']'] = '[';

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[') {
                stack.Push(s[i]);
            }
            else {
                if (stack.Count() == 0) {
                    return false;
                }

                char top = stack.Pop();

                if (top != dict[s[i]]) {
                    return false;
                }
            }
        }

        return stack.Count() == 0 ? true : false;
    }
}
