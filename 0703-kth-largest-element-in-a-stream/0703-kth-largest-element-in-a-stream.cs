public class KthLargest {

    private PriorityQueue<int, int> heap;
    private int k;

    public KthLargest(int pk, int[] nums) {
        
     heap = new PriorityQueue<int, int>();

     k = pk;

     foreach (int num in nums){
        heap.Enqueue(num, num);
        if (heap.Count > k)
        {
    heap.Dequeue();
     }
     }

      
    }
    
    public int Add(int val) {

        heap.Enqueue(val, val);
       if (heap.Count > k) {
         
            heap.Dequeue();
        } 

        return heap.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */