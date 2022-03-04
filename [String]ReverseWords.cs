public class program {

    //Time Complexity: O(n) | Space Complexity: O(1) because char is mutable value type
    public void ReverseWords(char[] words) {
        this.ReverseChar(words, 0, words.Length - 1);

        this.ReverseWords(words);
    }

    public void ReverseChar(char[] words, int start, int end) {
        while (start < end) {
            char temp = words[start];
            words[start++] = words[end];
            words[end--] = temp; 
        }
    }

    public void ReverseWords(char[] words) {
        int length = words.Length;
        int start = 0;
        int end = 0;

        while (start < length) {
            while (end < length && words[end] != ' ') {
                end++;
            }
            this.ReverseChar(words, start, end - 1);
            start = end + 1;
            end++;
        }
    }
}