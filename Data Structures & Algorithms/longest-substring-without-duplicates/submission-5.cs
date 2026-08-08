public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length < 2) {
            return s.Length;
        }

        Dictionary<char, int> seen = new Dictionary<char, int>();
        int len = 0, maxLen = 0;
        int l = 0, r = 0;

        while (r < s.Length) {
            if (!seen.ContainsKey(s[r])) {
                seen[s[r]] = r;
                len++;
            }
            else {
                maxLen = Math.Max(maxLen, len);
                len = r - seen[s[r]];
                int pos = seen[s[r]];
                while (l <= pos) {
                    seen.Remove(s[l]);
                    l++;
                }
                seen[s[r]] = r;
            }
            r++;
        }

        return Math.Max(maxLen, len);
    }
}
