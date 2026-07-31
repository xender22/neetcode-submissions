public class Solution {
    public int CountPaths(int[][] grid) 
    {
        int Dfs(int[][] grid, HashSet<(int, int)> visited, int row, int col)
        {
            var rowLimit = grid.Length;
            var colLimit = grid[0].Length;

            if (Math.Min(row, col) < 0 || row == rowLimit || 
            col == colLimit || visited.Contains((row, col)) || grid[row][col] == 1) 
                return 0;
            
            if (row == rowLimit -1 && col == colLimit - 1)
                return 1;

            visited.Add((row, col));
            
            var count = 0;

            count += Dfs(grid, visited, row + 1, col);
            count += Dfs(grid, visited, row - 1, col);
            count += Dfs(grid, visited, row, col + 1);
            count += Dfs(grid, visited, row, col - 1);

            visited.Remove((row, col));

            return count;
        }

        var visited = new HashSet<(int, int)>();
        var result = Dfs(grid, visited, 0, 0);
        return result;
    }
}
