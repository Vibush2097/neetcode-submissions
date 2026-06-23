public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;

        Dictionary<char, int> positions = new Dictionary<char, int>();
        HashSet<char> curSequence = new HashSet<char>();
        int maxLen =  0;
        // int len = 0;

        // for (int i = 0; i < s.Length; i++) {
        //     if (!curSequence.Contains(s[i])) {
        //         ++len;
        //         curSequence.Add(s[i]);
        //     }
        //     else {
        //         len = i - positions[s[i]];

        //         if (i > 0 && s[i] == s[i-1]) {
        //             len = 1;
        //             curSequence.Clear();
        //             curSequence.Add(s[i]);
        //         }
        //     }
        //     Console.WriteLine("len: " + len);
        //     maxLen = Math.Max(len, maxLen);
        //     positions[s[i]] = i;
        // }

        int start = 0, r = 0;

        while (r < s.Length) {
            if (curSequence.Contains(s[r])) {
                while (start < positions[s[r]] + 1) {
                    curSequence.Remove(s[start]);
                    start++;
                }
            }
            int len = r - start + 1;
            // Console.WriteLine($"len: {len}\t r: {r}\t start: {start}");
            curSequence.Add(s[r]);
            positions[s[r]] = r;
            maxLen = Math.Max(len, maxLen);
            r++;
        }

        return maxLen;
    }
}
