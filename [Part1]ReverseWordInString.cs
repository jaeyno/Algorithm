public class Solution {
    //Time Complexity: O(n) | Space Complexity: O(n)
    public string ReverseWordInString(string s) {
        //remove the white spaces;
        StringBuilder sb = this.TrimWhiteSpace(s, 0, s.Length - 1);
        //reverse each char
        this.ReverseChar(sb, 0, sb.Length - 1);
        //reverse each word back
        this.ReverseWord(sb);
        //return string
        return sb.ToString();
    }

    private StringBuilder TrimWhiteSpace(string s, int left, int right) {
        StringBuilder sb = new StringBuilder();

        //remove the leading white spaces
        while (left < right && !Char.IsLetterOrDigit(s[left])) {
            left++;
        }

        //remove the tailing white spaces
        while (left < right && !Char.IsLetterOrDigit(s[right])) {
            right--;
        }

        //append each char to string builder
        //one white space between each word
        while (left <= right) {
            if (Char.IsLetterOrDigit(s[left])) {
                sb.Append(s[left]);
            } else if (Char.IsLetterOrDigit(sb[sb.Length - 1])) {
                sb.Append(s[left]);
            }

            left++;
        }

        return sb;
    }

    private void ReverseChar(StringBuilder sb, int left, int right) {
        while (left < right) {
            char temp = sb[left];
            sb[left] = sb[right];
            sb[right] = temp;
            left++;
            right--;
        }
    }

    private void ReverseWord(StringBuilder sb) {
        int start = 0;
        int end = 0;

        while (start < sb.Length) {
            //find each word
            while (end < sb.Length && Char.IsLetterOrDigit(sb[end])) {
                end++;
            }

            //reverse each word
            this.ReverseChar(sb, start, end - 1);

            //start from next word
            start = end + 1;
            end++;
        }
    }
}