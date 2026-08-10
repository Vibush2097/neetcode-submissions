public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        int[] s1Count = new int[26];
        int[] s2Count = new int[26];
        bool equal = false;

        for (int i = 0; i < s1.Length; i++) {
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }
        
        for (int i = 0; i <= s2.Length - s1.Length; i++) {
            equal = true;
            for (int j = 0; j < 26; j++) {
                if (s1Count[j] != s2Count[j]) {
                    equal = false;
                    break;
                }
            }

            if (equal) {
                return true;
            }
            if (i < s2.Length - s1.Length) {
                s2Count[s2[i] - 'a']--;
                s2Count[s2[i + s1.Length] - 'a']++;
            }
        }

        return false;
    }
}

