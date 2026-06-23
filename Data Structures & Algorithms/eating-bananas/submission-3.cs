public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int sum = 0;
        int kMax = -1;

        for (int i=0; i<piles.Length; i++) {
            sum += piles[i];
            kMax = Math.Max(kMax, piles[i]);
        }

        int kMin = Math.Max(1, sum/h + (sum % h > 0 ? 1 : 0));

        int l = kMin;
        int r = kMax;
        int k;
        int result = kMax;

        while (l <= r) {
            k = l + (r-l)/2;

            if (this.getNumHoursForK(piles, k) <= h) {
                result = Math.Min(result, k);
                r = k - 1;
            }
            else
                l = k + 1;
        }
    
        return result;
    }

    public int getNumHoursForK(int[] piles, int k) {
        int hours = 0;

        for (int i=0; i < piles.Length; i++) {
            hours += piles[i] / k + (piles[i] % k > 0 ? 1 : 0);
        }

        return hours;
    }
}
