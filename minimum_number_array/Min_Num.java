import java.util.*;
class Min_Num{
    // static function can be used by any instance of the class
     
    static public int[] numberGame(int[] nums) {
        int [] arr = new int[nums.length]; 
        Arrays.sort(nums);

        for (int i =0; i < nums.length-1; i+=2) {
        int alice = nums[i];
        int bob = nums[i+1];
        arr[i] = bob;
        arr[i+1] = alice; 
        }
        return arr;
        
    }
    public static void main(String[] args){
        int[] passarr = {5,4,3,2};

        passarr = numberGame(passarr);    
        System.out.println(Arrays.toString(passarr));
        System.out.println("the awnser should be 3,2,5,4");

    }

    };