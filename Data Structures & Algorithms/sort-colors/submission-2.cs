public class Solution {
    public void SortColors(int[] nums) 
    {
        var colors = new int[] {0, 0, 0};

        foreach (int num in nums) 
            colors[num]++;

        var clrIdx = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            while (colors[clrIdx] <= 0)
                clrIdx++;

            nums[i] = clrIdx;
            colors[clrIdx]--;   
        }
    }
}