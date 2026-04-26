public class Solution {
    public int LengthOfLongestSubstring(string s) {

        //longest string to be returned
        string longest_string = "";
        //working substring to be 
        List<char> w_s = new List<char>();

            for (int i=0; i < s.Length; i++)
            {   
                if(w_s.Contains(s[i]))
                {
                    
                    if (w_s.Count > longest_string.Length)
                    {
                        //string.join(delimeter,list) use "" for no delimeter
                        longest_string = string.Join("",w_s);   
                    }
                    w_s.Clear();
                    
                }
                
                w_s.Add(s[i]);   
            }

            if (w_s.Count > longest_string.Length)
            {
                //string.join(delimeter,list) use "" for no delimeter
                longest_string = string.Join("",w_s);
            }

        return longest_string.Length;
    }

}