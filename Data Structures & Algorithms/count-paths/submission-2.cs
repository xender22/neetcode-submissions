public class Solution {
    public int UniquePaths(int m, int n) 
    {
        var prevRow = new int[n].ToList();

        for (int i = m - 1; i >= 0; i--) 
        {
            var currRow = new int[n].ToList();
            currRow[n - 1] = 1;

            for (int j = n - 2; j >= 0; j--)
            {
                currRow[j] = prevRow[j] + currRow[j + 1];
            }
            prevRow = currRow;
        }

        return prevRow[0];
        
    }
}
