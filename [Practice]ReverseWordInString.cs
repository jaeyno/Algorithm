public class Program {
    //Time Complexity: O(n) | Space Complexity: O(n)
    public string ReverseWordInString(string s) {
        StringBuilder sb = this.TrimSpace(s);
        this.ReverseChars(sb, 0, s.Length);
        this.ReverseEachWord(sb);
        return sb.ToString();
    }

    //Remove leading and tailing spaces
    private StringBuilder TrimSpace(string s) {
        int left = 0;
        int right = s.Length - 1;

        //remove leading spaces
        while (left < right && !Char.IsLetter(s[left])) {
            left++;
        }

        //remove tailing spaces
        while (left < right && !Char.IsLetter(s[right])) {
            right--;
        }

        StringBuilder sb = new StringBuilder();
        while (left <= right) {
            if (Char.IsLetter(s[left])) {
                sb.Append(s[left]);
            } else if (Char.IsLetter(sb[sb.Length - 1])) {
                sb.Append(s[left]);
            }
            left++;
        }

        return sb;
    }

    private void ReverseChars(StringBuilder sb, int left, int right) {
        while (left < right) {
            char temp = sb[left];
            sb[left] = sb[right];
            sb[right] = temp;
            left++;
            right--;
        }
    }

    private void ReverseEachWord(StringBuilder sb) {
        int start = 0;
        int end = 0;

        while(start < sb.Length) {
            //find each word separated by a white space
            while (end < sb.Length && Char.IsLetter(sb[end])) {
                end++;
            }

            this.ReverseChars(sb, start, end - 1);
            start = end + 1;
            end++;
        }
    }
}