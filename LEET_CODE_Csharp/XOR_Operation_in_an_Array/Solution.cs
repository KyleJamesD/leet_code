public class Solution {
    public int XorOperation(int n, int start) {
        int[] nums = new int[n];

        for (int i=0; i < nums.Length; i++){
            nums[i] = start + 2 * i;
        }

        int xor = 0;
        for (int i = 0; i < nums.Length; i++){

                xor = xor ^ nums[i];
            
        }

        return xor;
    }
}