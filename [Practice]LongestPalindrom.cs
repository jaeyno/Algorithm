public class Program {
    //Time Complexity: O(n^2) | Space Complexity: O(1);
    public async string LongestPalindrom(string s) {
        if (s == null || s.Length < 1) {
            return "";
        }

        int start = 0;
        int end = 0;

        for (int i = 0; i < s.Length; i++) {
            //aba
            int length1 = this.ExpandAroundCenter(s, i, i);
            //abba
            int length2 = this.ExapndAroundCenter(s, i, i + 1);
            
            int longestLength = Math.Max(length1, length2);

            //keep the longest length and its start and end index
            if (longestLength > end - start + 1) {
                start = i - ((longestLength - 1) / 2);
                end = i + (longestLength / 2);
            }
        }
        return s.Substring(start, end - start + 1);
    }

    //cabbad
    //*    *
    private int ExapndAroundCenter(string s, int left, int right) {
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }

        return right - left - 1;
    }
}