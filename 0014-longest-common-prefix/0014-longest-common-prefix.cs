public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        int firstindex=0;
        int thirdindex =strs.Length-1;
        String  repeating_final ="";

        Array.Sort(strs);
        
        for (int i = 0; i<strs[firstindex].Length; i++){

            if (strs[firstindex][i]==strs[thirdindex][i]){
                repeating_final += strs[firstindex][i];
            }
            else {
                return repeating_final;
                break;
            }
                    


        }
        return repeating_final ;


    }
}