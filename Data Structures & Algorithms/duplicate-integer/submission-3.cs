public class Solution 
{
    public bool hasDuplicate(int[] nums) 
    {
        var dupes = new HashSet<int>();

        foreach (var num in nums)
        {
            if (dupes.Contains(num))
                return true;
            else
                dupes.Add(num);
        }
        return false;
    }
}