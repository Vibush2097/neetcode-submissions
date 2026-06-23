public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) {
            return false;
        }

        int[] s1Count = new int[26];
        // int[] s2Count = new int[26];
        for (int i = 0; i < s1.Length; i++) {
            s1Count[s1[i] - 'a']++;
            // s2Count[s2[i] - 'a']++;
        }

        int windowLen = s1.Length;

        for (int i = 0; i <= (s2.Length - s1.Length); i++) {
            int[] s2Count = new int[26];

            for (int j = i; j < (i + windowLen); j++) {
                s2Count[s2[j] - 'a']++;
            }

            bool foundMatch = true;
            for (int j = 0; j < 26; j++) {
                if (s1Count[j] != s2Count[j]) {
                    foundMatch = false;
                    break;
                }
            }

            if (foundMatch)
                return true;
        }

        return false;
    }
}
