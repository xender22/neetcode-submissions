class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        lowest_price = prices[0]
        profit = 0

        for p in prices:
            curr_profit = p - lowest_price
            if curr_profit > profit:
                profit = curr_profit
            if lowest_price > p:
                lowest_price = p
        
        return profit

        