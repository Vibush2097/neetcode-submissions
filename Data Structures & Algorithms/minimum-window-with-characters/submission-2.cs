public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length)
            return "";

        int[] tCount = new int[58];
        int[] sCount = new int[58];

        for (int i = 0; i < t.Length; i++) {
            tCount[t[i] - 'A']++;
        }

        for (int i = 0; i < s.Length; i++) {
            sCount[s[i] - 'A']++;
        }

        for (int i = 0; i < s.Length; i++) {
            if (sCount[s[i] - 'A'] < tCount[s[i] - 'A'])
                return "";
        }

        int l = 0, r = s.Length - 1;

        while (l < r && (sCount[s[l] - 'A'] - 1) >= tCount[s[l] - 'A']) {
            sCount[s[l] - 'A']--;
            l++;
        }

        while (l <= r && (sCount[s[r] - 'A'] - 1) >= tCount[s[r] - 'A']) {
            sCount[s[r] - 'A']--;
            r--;
        }

        string result = "";

        while (l <= r) {
            result += s[l];
            l++;
        }

        return result;
    }
}
