public class Graph 
{
    private Dictionary<int, List<int>> Map {get;set;}

    public Graph() 
    {
        Map = new Dictionary<int, List<int>>();
    }

    public void AddEdge(int src, int dst) 
    {
        if (!Map.ContainsKey(src))
            Map[src] = new List<int>();

        
        if (!Map[src].Contains(dst))
            Map[src].Add(dst);
    }

    public bool RemoveEdge(int src, int dst) 
    {
        if (!Map.ContainsKey(src))
            return false;
        
        if (!Map[src].Contains(dst))
            return false;
        
        Map[src].Remove(dst);
        return true;
    }

    public bool HasPath(int src, int dst) 
    {
        var queue = new Queue<int>();
        var visited = new HashSet<int>();
        queue.Enqueue(src);
        visited.Add(src);

        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();

            if (curr == dst)
                return true;
            
            if (!Map.ContainsKey(curr))
                continue;
                
            foreach (var edge in Map[curr])
            {
                if (!visited.Contains(edge))
                {
                    visited.Add(edge);
                    queue.Enqueue(edge);
                }
            }
        }
        
        return false;
    }

}