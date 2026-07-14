public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], int> heap = new PriorityQueue<int[], int>();
            int[][] answer = new int[k][];

        for (int i = 0 ; i <= points.Length-1; i++){
            int x = points[i][0];
            int y = points [i][1];

           int distance = x * x + y * y; 
          
           heap.Enqueue(new int[] {x , y } ,-distance);

           while(heap.Count >k) {
            heap.Dequeue();
           }


        }

           for(int a =0 ; a < k ; a++){
    answer[a]= heap.Dequeue();
   }

   return answer;



        

        
      

      



    }
}