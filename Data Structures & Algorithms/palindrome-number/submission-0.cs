public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) 
            return false;

        List<int> digits = new List<int>();
        int num = x;

        while (num > 0) {
            digits.Add(num % 10);
            num = num / 10;
        }

        int n = digits.Count;
        for (int i = 0; i < n / 2; i++) {
            if (digits[i] != digits[n - 1 - i]) 
                return false;
        }

        return true;
    }
}