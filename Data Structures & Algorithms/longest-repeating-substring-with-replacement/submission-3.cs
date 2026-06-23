public class Solution {
    public int CharacterReplacement(string s, int k) {
        var counts = new Dictionary<char, int>();
        int l = 0, r = 0, maxLen = 0;
        int windowLen = 0, maxF = 0;

        for (int i = 0; i < s.Length; i++) {
            counts[s[i]] = 0;
        }

        while (l <= r && r < s.Length) {
            counts[s[r]]++;
            windowLen = r - l + 1;
            maxF = 0;

            foreach (var entry in counts) {
                maxF = Math.Max(entry.Value, maxF);
            }

            Console.WriteLine($"windowLen: {windowLen} \t maxF: {maxF} \t l: {l} \t r: {r}");
            if ((windowLen - maxF) <= k) {
                maxLen = Math.Max(windowLen, maxLen);
                r++;
            }
            else {
                counts[s[l]]--;
                counts[s[r]]--; // Since we increment the count on every iteration
                l++;
            }
        }

        return maxLen;
    }
}
