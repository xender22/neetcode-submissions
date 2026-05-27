public class Solution {

    char encodeChar = '\u001F';

    public string Encode(IList<string> strs) {
        string result = "";
        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i]++;
            }

            string encodedStr = new string(chars);
            result += encodedStr + encodeChar;

        }

        return result;
        
    }

    public List<string> Decode(string s) {
        string[] encodedStrngs = s.Split(encodeChar);

        List<string> result = new();

        foreach (string encoded in encodedStrngs) 
        {
            char[] chars = encoded.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i]--;
            }

            string decoded = new string(chars);
            result.Add(decoded);
        }
        result.RemoveAt(result.Count -1);
        
        return result;
   }
}
