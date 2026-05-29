public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int highest = 0;
        HashSet<char> uniqChars = new();

        for (int right = 0; right < s.Length; right++)
        {
            while (uniqChars.Contains(s[right])) 
            {
                uniqChars.Remove(s[left]);
                left++;
            }

            uniqChars.Add(s[right]);
            highest = Math.Max(highest, right - left + 1);
            
        }


        return highest;

    }
}
