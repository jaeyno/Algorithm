public class Program {
    public int LengthOfLongestSubstring(string s, int k) {
        if (k == 0) return 0;

        int left = 0;
        int right = 0;
        int maxLength = 1;

        Dictionary<char, int> characters = new Dictionary<char, int>();

        while (right < s.Length) {
            if (characters.ContainsKey(s[right])) {
                characters.Remove(s[right]);
            }

            characters.Add(s[right], right++);

            //if the number of elements stored in dictionary is greater than given k
            if (characters.Count > k) {
                int mostLeftIndex = characters.Values.Min();
                left = mostLeftIndex + 1;
                characters.remove(s[mostLeftIndex]);
            }

            maxLength = Math.Max(maxLength, right - left);
        }

        return maxLength;
    }
}