public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) 
    {
        void Dfs(int[][] image, int sr, int sc, int color, int target)
        {
            var colLimit = image[0].Length;
            var rowLimit = image.Length;
            
            if (target == color) return;

            if (sc < 0 || sr < 0 || 
            sr == rowLimit || sc == colLimit || 
            image[sr][sc] != target)
                return;

            if (image[sr][sc] == target)
                image[sr][sc] = color;
       

            Dfs(image, sr + 1, sc, color, target);
            Dfs(image, sr - 1, sc, color, target);
            Dfs(image, sr, sc + 1, color, target);
            Dfs(image, sr, sc - 1, color, target);
        }

        var target = image[sr][sc];
        Dfs(image, sr, sc, color, target);
        return image;
    }
}