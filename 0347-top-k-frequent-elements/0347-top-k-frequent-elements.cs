public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new();
        PriorityQueue<int, int> heap = new();
         int[] answer = new int[k];
    


        foreach (int num in nums){

            if (frequency.ContainsKey(num)){
                frequency[num]++;
            }
            else {
            frequency[num] = 1;
            }

            
        }

        foreach (var x in frequency)
{
    heap.Enqueue(x.Key, x.Value);

    if (heap.Count > k)
    {
        heap.Dequeue();
    }
}
    
   for(int a =0 ; a < k ; a++){
    answer[a] = heap.Dequeue();
   }

   return answer;
    
        
    }
}