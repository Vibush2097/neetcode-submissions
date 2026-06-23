public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        int f=0, b=s.Length-1;

        while (f < b) {
            while (!Char.IsLetterOrDigit(s[f])) {
                ++f;
                if (f == s.Length)
                    break;
            }
                
            while (!Char.IsLetterOrDigit(s[b])) {
                --b;

                if (b == -1)
                    break;
            }

            if (f == s.Length && b==-1)
                return true;

            if (s[f] != s[b])
                return false;
            f++;
            b--;
        }

        return true;
    }
}
