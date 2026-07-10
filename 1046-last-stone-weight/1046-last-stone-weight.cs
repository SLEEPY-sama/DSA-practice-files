public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();

        foreach(int stone in stones){
            heap.Enqueue(stone, -stone);
        }
       
       if (heap.Count == 1){
           
        return heap.Peek();
       }
       do { 
        int stone1 = heap.Dequeue();
        
        int stone2 = heap.Dequeue();
       

        int result = Smashstones(stone1 , stone2);
        if (result != 0){
        heap.Enqueue(result,-result);
        }

       }while(heap.Count >= 2);
            
          
       if (heap.Count == 1){
           
        return heap.Peek();
       }
       else {
        return 0;
       }
        
        



    }

    public int Smashstones(int stone1, int stone2 ){
         int result = stone1 - stone2;
         return result;

    }
}