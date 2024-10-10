public class Solution {
    public int MaxProfit(int[] prices) {
        int result = 0;
        int max = 0;
        for (int i = prices.Length - 1; i >= 0; i--)
        {
            if(prices[i] > max)
                max = prices[i];
            if(max - prices[i] >= result)
                result = max - prices[i];
        }
        return result;
    }
}
