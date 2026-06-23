public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> indexes = new Dictionary<char, int>();
        int l = 0, maxLen = 0;

        for (int r = 0; r < s.Length; r++) {
            if (indexes.ContainsKey(s[r])) {
                l = Math.Max(indexes[s[r]] + 1, l);
            }

            indexes[s[r]] = r;
            maxLen = Math.Max(maxLen, r - l + 1);
        }

        return maxLen;
    }
}
