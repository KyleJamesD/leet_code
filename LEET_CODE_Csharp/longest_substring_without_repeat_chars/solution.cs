public class Solution {
    public int LengthOfLongestSubstring(string s) {

        int start_pos_awnser = 0;
        int end_pos_awnser;
        int curr_index_outer;
        int curr_index_inner;
        string longest_substring= "";

        for (int i=0; i < s.Length; i++)
        {

            for (int r=0; r < s.Length; r++)
            {
                if (r = 0)
                {
                    continue;
                }
                    if (s[r] == s[r-1])
                    {
                        int end_pos_awnser_check = r - 1 - start_pos_awnser;
                        //.substring works by param1 = index to start at, param2 = length to extract
                        // param1 = 0 , and param2 = 3 , will extract index 0,1,2
                        if (longest_substring.Length < end_pos_awnser_check)
                        {
                            end_pos_awnser = end_pos_awnser_check;
                            longest_substring = s.substring(start_pos_awnser,end_pos_awnser);

                            start_pos_awnser = r + 1;
                        }
                    }

                
            }
            
            
        }
        
    }
}