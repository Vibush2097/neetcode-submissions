public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] counts = new int[26];
        int l = 0, r = 0;
        int maxLen = 1;

        while (r < s.Length) {
            counts[s[r] - 'A']++;
            int maxF = GetMaxFreq(counts);
            int windowLen = r - l + 1;

            if (windowLen - maxF <= k) {
                maxLen = Math.Max(maxLen, windowLen);
                r++;
            }
            else {
                counts[s[l] - 'A']--;
                l++;
                counts[s[r] - 'A']--;
            }
        }

        return maxLen;
    }

    private int GetMaxFreq(int[] counts) {
        int maxF = 0;

        for (int i = 0; i < counts.Length; i++) {
            maxF = Math.Max(counts[i], maxF);
        }

        return maxF;
    }
}
