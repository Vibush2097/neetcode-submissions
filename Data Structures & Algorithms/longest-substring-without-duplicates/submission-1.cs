public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length < 2)
            return s.Length;

        int l = 0;
        int res = 0;
        HashSet<char> charSet = new HashSet<char>();

        for (int r=0; r<s.Length; r++) {
            while (charSet.Contains(s[r])) {
                charSet.Remove(s[l]);
                l++;
            }
            charSet.Add(s[r]);
            res = Math.Max(res , r - l + 1);
        }
        
        return res;
    }
}
