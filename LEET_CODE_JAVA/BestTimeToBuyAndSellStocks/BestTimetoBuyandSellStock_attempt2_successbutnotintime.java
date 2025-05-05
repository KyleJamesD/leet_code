class Solution {
    
    int [] prices = new int[]{7,1,5,3,6,4};
    int profit = 0;
    public int maxProfit(int[] prices) {
        for(int i =0; i < prices.length; i++){
            for(int k = i+1; k < prices.length; k++){
                if (prices[k] - prices[i] > profit)
                {
                    profit = prices[k] - prices[i];
                }
            }
        }
        if (profit > 0)
        {
            return profit;
        }
        else {
            return 0;
        }
    }
}