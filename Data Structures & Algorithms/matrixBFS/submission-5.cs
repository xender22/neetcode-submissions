public class Solution {
    public int ShortestPath(int[][] grid) 
    {
        var rCnt = grid.Length;
        var cCnt = grid[0].Length;

        if (grid[0][0] == 1 || grid[rCnt - 1][cCnt - 1] == 1)
            return -1;

        var queue = new Queue<(int, int)>();
        var visited = new HashSet<(int, int)>();
        queue.Enqueue((0, 0));
        visited.Add((0, 0));

        var length = 0;
        while (queue.Count != 0) 
        {   
           var currCount = queue.Count;

           for (var i = 0; i < currCount; i++)
           {
                var curr = queue.Dequeue();
                var (r, c) = curr;

                if (r == rCnt - 1 && c == cCnt - 1)
                    return length;

                var neighbors = new int[][]
                {
                    new[] { 0, 1 },
                    new[] { 0, -1 },
                    new[] { 1, 0 },
                    new[] { -1, 0 }
                };

                foreach (var n in neighbors)
                {
                   int nr = r + n[0];
                   int nc = c + n[1];

                    if (nr < 0 || nc < 0 || nr >= rCnt || nc >= cCnt ||
                        visited.Contains((nr, nc)) || grid[nr][nc] == 1)
                        continue;

                    queue.Enqueue((nr, nc));
                    visited.Add((nr, nc));
                }
           }
           length++;
        }

        return -1;
    }
}
