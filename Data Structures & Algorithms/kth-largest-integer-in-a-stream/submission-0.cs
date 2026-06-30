public class KthLargest {

    private int k;
    private PriorityQueue<int, int> minHeap;

    public KthLargest(int k, int[] nums) 
    {
        this.k = k;
        this.minHeap = new PriorityQueue<int, int>();
        foreach (var num in nums) 
        {
            minHeap.Enqueue(num, num);
            if (minHeap.Count > k)
                minHeap.Dequeue();
        }
    }
    
    public int Add(int val) 
    {
        minHeap.Enqueue(val, val);

        if (minHeap.Count > k)
            minHeap.Dequeue();
        
        return minHeap.Peek();
    }
}
