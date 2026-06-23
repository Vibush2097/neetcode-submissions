public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1, r = -1, m;
        
        for (int i = 0; i < piles.Length; i++) {
            r = Math.Max(piles[i], r);
        }

        // I want the minimum value of m such that
        // hours <= h
        int ans = 0;
        while (l <= r) {
            m = l + (r - l) / 2;

            int hours = HoursNeeded(piles, m);

            if (hours <= h) {
                ans = m;
                r = m - 1;
            }
            else {
                l = m + 1;
            }
        }

        return ans;
    }

    public int HoursNeeded(int[] piles, int k) {
        int sum = 0;
        foreach (var num in piles) {
            sum += (int) Math.Ceiling((double) num / k);
        }
        return sum;
    }
}
