public class Solution {
    public string LongestPalindrome(string s) {
        // Brute force solution
        int longest = 0;
        string result = "";

        for (int i = 0; i < s.Length; i++) {
            // Odd length
            int l = i, r = i;
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                if (r - l + 1 > longest) {
                    result = s.Substring(l, r - l + 1);
                    longest = r - l + 1;
                }

                l -= 1;
                r += 1;
            }

            // Even length
            l = i;
            r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                if (r - l + 1 > longest) {
                    result = s.Substring(l, r - l + 1);
                    longest = r - l + 1;
                }

                l -= 1;
                r += 1;
            }
        }

        return result;
    }

    private bool CheckPalindrome(string s, int i, int j) {
        while (i < j) {
            if (s[i] != s[j])
                return false;
            i++;
            j--;
        }

        return true;
    }
}