class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        profit = 0

        # We are basically buying at local minima and selling at local maxima
        # hence we keep adding any positive difference in stock price
        for i in range(1, len(prices)):
            if prices[i] >= prices[i - 1]:
                profit += (prices[i] - prices[i - 1])
        
        return profit