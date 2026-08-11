public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length) {
            return "";
        }

        var tCount = new Dictionary<char, int>();
        var sCount = new Dictionary<char, int>();

        foreach (var c in t) {
            if (!tCount.ContainsKey(c)) {
                tCount[c] = 1;
            }
            else {
                tCount[c]++;
            }
        }

        int l = 0, r = 0, tIndex = 0;
        int minLen = s.Length;
        string result = "";

        while (r < s.Length) {
            if (!sCount.ContainsKey(s[r])) {
                sCount[s[r]] = 1;
            }
            else {
                sCount[s[r]]++;
            }

            if (tIndex != t.Length && tCount.ContainsKey(s[r])) {
                if (sCount[s[r]] <= tCount[s[r]]) {
                    tIndex++;
                }
            }

            if (tIndex == t.Length) {
                while (l <= r) {
                    if (!tCount.ContainsKey(s[l]) || sCount[s[l]] > tCount[s[l]]) {
                        sCount[s[l]]--;
                        l++;
                    }
                    else {
                        break;
                    }
                }

                int len = r - l + 1;

                if (len <= minLen) {
                    result = s.Substring(l, len);
                    minLen = len;
                }
            }

            r++;
        }

        return result;
    }
}
