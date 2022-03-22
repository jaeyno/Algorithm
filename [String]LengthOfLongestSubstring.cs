public class Program {
    //Time Complexity: O(n) | Space Complexity: O(k)
    public int LengthOfLongestSubstring(string s, int k ) {
        if (k == 0) {
            return 0;
        }

        int left = 0;
        int right = 0;
        int maxLength = 1;

        Dictionary<char, int> rightMostPosition = new Dictionary<char, int>();

        while (right < s.Length) {
            if (rightMostPosition.ContainsKey(s[right])) {
                rightMostPosition.Remove(s[right]);
            }

            rightMostPosition.Add(s[right], right++);

            if (rightMostPosition.Count > k) {
                int leftMostPosition = rightMostPosition.Values.Min();
                rightMostPosition.Remove(s[leftMostPosition]);
                left = leftMostPosition + 1;
            }

            maxLength = Math.Max(maxLength, right - left);
        }

        return maxLength;
    }
}