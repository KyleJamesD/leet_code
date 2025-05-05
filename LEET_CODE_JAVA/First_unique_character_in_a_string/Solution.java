class Solution {
    public int firstUniqChar(String s) {
        String slice = "";
        String back = "";
        for(int i=0; i < s.length(); i++)
        {
            String char1 = String.valueOf(s.charAt(i));
            if(i == 0){
            slice = s.substring(i+1,s.length());
                if (!slice.contains(char1)){
                    return i;
                }
                back = char1;
            }
            if (i > 0) {
                slice = back + s.substring(i+1,s.length());
                if (!slice.contains(char1)){
                    return i;
                }
                back = back + char1;
            }
        }
        return -1;    
    }
}
