class Solution {
    
    int [] prices = new int[]{7,1,5,3,6,4};
    int lowestValue = prices[0];
    int lowestValueIndex = 0;
    int bestDayTosell = 0;
    int bestDayTosellIndex;
    int profit;

    public int maxProfit(int[] prices) {
        for(int i =0; i < prices.length; i++){
            if (prices[i] < lowestValue ){
                lowestValue = prices[i];
                lowestValueIndex = i;
            }
        }

        for(int k = lowestValueIndex+1 ; k < prices.length; k++){
            if (prices[lowestValueIndex] < prices[k] ) {
                if (bestDayTosell > prices[k])
                {}
                else{
                    bestDayTosell = prices[k];
                    bestDayTosellIndex = k;
                }
            }
        }
        profit = bestDayTosell - lowestValue;
        if (profit > 0)
        {
            return profit;
        }
         else{
            return 0;
        }     
    }
}