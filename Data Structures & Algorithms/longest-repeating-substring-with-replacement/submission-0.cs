public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] charCounts = new int[26];
        int l = 0, r, maxLength = 0;

        for (r = 0; r < s.Length; r++) {
            charCounts[s[r]-'A']++;
            int maxF = 0;

            for (int j=0; j<26; j++) {
                maxF = Math.Max(maxF, charCounts[j]);
            }

            int checkWindow = (r-l+1) - maxF;

            if (checkWindow > k) {
                charCounts[s[l]-'A']--;
                l++;
            }

            maxLength = Math.Max(maxLength, r-l+1);
        }
        return maxLength;
    }
}
