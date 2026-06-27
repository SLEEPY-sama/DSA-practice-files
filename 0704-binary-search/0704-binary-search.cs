public class Solution {
    public int Search(int[] nums, int target) {
        
        for (int i = 0; i<nums.Length; i++){
            if (nums[i]== target){
                return i;

            }
            else if (!nums.Contains(target)){
                return -1;
            }
        }

        return -1;

    }
}