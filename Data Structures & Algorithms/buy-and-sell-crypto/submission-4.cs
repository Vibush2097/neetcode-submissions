public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1, profit = 0, maxProfit = 0;

        while (r < prices.Length) {
            maxProfit = Math.Max(maxProfit, prices[r] - prices[l]);
            if (prices[l] > prices[r]) {
                l = r;
            }
            r++;
        }

        return maxProfit;
    }
}