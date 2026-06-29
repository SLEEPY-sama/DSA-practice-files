/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        
        int left = 0 ;
        int right = n;
        int smallestint =int.MaxValue;

        while (left < right ){

           int  mid = left + (right -left) / 2 ;
          
            if (IsBadVersion(mid) ){
                right = mid  ;
            }
            else if (!IsBadVersion(mid)){
               left = mid +1 ;
            }
           
           // if (IsBadVersion(right) && (!IsBadVersion(left)&& left == mid-1)){
          //      //return right;
           //     continue;
          //  }
        
            
            
        }

        return right;


    }
}