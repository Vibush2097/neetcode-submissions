public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int profit = 0, maxProfit = 0;

        for (int i = 1; i < prices.Length; i++) {
            profit = prices[i] - Math.Min(minPrice, prices[i]);
            maxProfit = Math.Max(profit, maxProfit);
            minPrice = Math.Min(prices[i], minPrice);
        }

        return maxProfit;
    }
}
