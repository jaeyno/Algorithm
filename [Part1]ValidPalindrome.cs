public class Solution {
    //Time Complexity: O(n) | Space Complexity: O(1)
    public bool IsValidPalindrome(string s) {
        //Make two pointers
        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            //if it is non-alphanumeric character, skip
            if (!Char.IsLetterOrDigit(s[left])) {
                left++;
                continue;
            }

            //if it is non-alphanumeric character, skip
            if (!Char.IsLetterOrDigit(s[right])) {
                right--;
                continue;
            }

            //1.convert to lowercae
            //2.compare s[left] and s[right]
            //3.if is not equal to each other, return false;
            if (Char.ToLower(s[left]) != Char.ToLower(s[right])) {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}