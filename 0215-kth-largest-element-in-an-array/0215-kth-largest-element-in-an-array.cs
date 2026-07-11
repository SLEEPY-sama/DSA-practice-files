public class Solution {
    public int FindKthLargest(int[] nums, int k) {

        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();

        foreach(int num in nums){
            heap.Enqueue(num,-num);
        }


        for (int i = 0 ; i < k-1; i++ ){
            heap.Dequeue();
        }

        return heap.Peek();


        
    }
}