public class Solution {
    public int MaxProfit(int[] prices) {
        
        int windowStart = 0;
        int maxProfit = 0;

        for(int windowEnd = 0; windowEnd < prices.Count(); windowEnd++) {

            var l = prices[windowStart];
            var r = prices[windowEnd];

            if(l < r) {
                maxProfit = Math.Max(r-l, maxProfit);
            }
            else {
                windowStart = windowEnd;
            }
        }

        return maxProfit;

    }
}