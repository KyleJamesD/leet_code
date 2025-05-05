public class Solution {
    public int CountDigits(int num) {

        char[] singleNums = Convert.ToString(num).ToCharArray();

        int counter = 0;
        for (int i=0; i < singleNums.Length; i++){
            if(num % Convert.ToInt32(Char.GetNumericValue(singleNums[i])) == 0)
            {
                counter ++;
            }
        }
        
        return counter;
    }
}