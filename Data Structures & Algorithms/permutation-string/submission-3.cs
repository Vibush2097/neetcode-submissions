public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] s1Counts = new int[26];
        int[] s2Counts = new int[26];

        foreach (var c in s1) {
            s1Counts[c - 'a']++;
        }

        foreach (var c in s2) {
            s2Counts[c - 'a']++;
        }

        // Counts of each char in s2 have to be greater than or equal to the counts
        // of each char in s1
        for (int i = 0; i < 26; i++) {
            if (s2Counts[i] < s1Counts[i]) {
                return false;
            }
        }

        int[] windowCounts = new int[26];

        for (int i = 0; i < s1.Length; i++) {
            windowCounts[s2[i] - 'a']++;
        }

        if (sameCounts(windowCounts, s1Counts)) return true;

        for (int i = 1; i < s2.Length - s1.Length + 1; i++) {
            windowCounts[s2[i - 1] - 'a']--;
            windowCounts[s2[i + s1.Length - 1] - 'a']++;

            if (sameCounts(windowCounts, s1Counts)) return true;
        }

        return false;
    }

    public bool sameCounts(int[] a, int[] b) {
        for (int i = 0; i < 26; i++) {
            if (a[i] != b[i]) return false;
        }

        return true;
    }
}
