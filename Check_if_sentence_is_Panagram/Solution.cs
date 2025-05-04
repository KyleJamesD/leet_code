public class Solution {
    public bool CheckIfPangram(string sentence) {
        char[] letters = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

        bool istrue = false;

        if (sentence.Length < 26)
        {
            return false;
        }

        for( int i =0; i < sentence.Length; i++){
            istrue = false;
            istrue = Array.Exists(letters, e => e == sentence[i]);

            if(istrue == true){
            int position = Array.IndexOf(letters, sentence[i]);
            letters[position] = '1';
            }
        }

            bool allLetters  = true;
        for (int i=0; i < letters.Length; i++){
            if(letters[i] != '1'){
                allLetters = false;
            }
        } 

        return allLetters;

        
    }
}