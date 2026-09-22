public class Solution {
    public int HammingWeight(uint n) 
    {
        var count = 0;

        while (n > 0)
        {
            var currAnd = n & 1;
            if ( currAnd == 1 )
                count++;
            n = n >> 1;
        }

        return count;
    }
}
