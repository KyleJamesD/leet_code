public class Solution {
    public string FirstPalindrome(string[] words) {

        char[] charAr;
        string revWord;

        for (int i= 0; i < words.Length; i++){

            charAr = words[i].ToCharArray();

            Array.Reverse(charAr);

            revWord =  new string(charAr);

            if (revWord.Equals(words[i])){
                return words[i];
            }
        }

        return ""; 
        
    }
}