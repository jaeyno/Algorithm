public class Solution {
    //Time Complexity: O(n) | Space Complexity: O(1)
    //given input: array of characters
    public void ReverseString(char[] s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            this.Reverse(s, left, right);
            left++;
            right--;
        }
    }

    private void Reverse(char[] s, int left, int right) {
        char temp = s[left];
        s[left] = s[right];
        s[right] = temp;
    }
}