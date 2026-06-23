public class Solution {
    public bool IsPalindrome(string s) {
        int m = 0, n = s.Length - 1;

        while (m < n && m < s.Length && n >= 0) {
            if (!char.IsLetterOrDigit(s[m])) {
                m++;
                continue;    
            } 

            if (!char.IsLetterOrDigit(s[n])) {
                n--;
                continue;
            }

            if (char.ToLower(s[m]) != char.ToLower(s[n])) return false;
            m++;
            n--;
        }

        return true;
    }
}
