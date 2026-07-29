public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length > t.Length) return false;

        int start = 0;

        for (int i = 0; i < t.Length; i++) {
            if (start == s.Length) {
                return true;
            }

            if (s[start] == t[i]) {
                start++;
            }
        }

        return start == s.Length;
    }
}