public class Solution {
    public int Search(int[] nums, int target) {
       
       int right = nums.Length-1;
       int left = 0;

       while  (right >= left ){
        
        int mid = left + (right- left )/2;

        if (nums[mid] < target ){
            left = mid+1  ;
        }
        else if (nums[mid] > target){
            right = mid-1 ;
        }


        if (nums[mid]== target){
            return mid;
            
        }
        
   


       }
       return -1;

       


    

    }
}