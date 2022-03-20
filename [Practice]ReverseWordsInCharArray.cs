public class Program {
    //apple is bad
    //dab si elppa
    //bad is apple
    //Time Complexity: O(n) | Space Complexity: O(1)
    public void ReverseWordsInCharArray(char[] s) {
        this.ReverseChars(s, 0, s.Length - 1);
        this.ReverseEachWord(s);
    }

    private void ReverseChars(char[] words, int start, int end) {
        while (start < end) {
            char temp = words[start];
            words[start] = words[end];
            words[end] = temp;
            start++;
            end--;
        }
    }

    private void ReverseEachWord(char[] words) {
        int length = words.Length;
        int start = 0;
        int end = 0;

        while (start < length) {
            //get each word, which is separated by white space
            while (end < length && words[end] != ' ') {
                end++;
            }
            this.ReverseChars(words, start, end - 1);

            //move to next word
            start = end + 1;
            end++;
        }
    }
}