public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> map = new Dictionary<char, char>() {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        Stack<char> stack = new Stack<char>();
    
        for (int i=0; i<s.Length; i++) {
            if (s[i]=='(' || s[i]=='{' || s[i]=='[')
                stack.Push(s[i]);
            else {
                if (stack.Count == 0)
                    return false;
                var top = stack.Pop();
                if (top != map[s[i]])
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
