class Solution {
    public String reverseWords(string s) {
        //I will use deque method to reverse the string
        int leftPointer = 0;
        int rightPointer = s.length() - 1;

        //remove the leading white spaces
        while (leftPointer <= rightPointer && s.charAt(leftPointer) == ' ') {
            leftPointer++;
        }

        //remove the trailing white spaces
        while (leftPointer <= rightPointer && s.charAt(rightPointer) == ' ') {
            rightPointer--;
        }

        //make a deque[]
        Deque<String> deque = new ArrayDeque();

        //make a mutable variable
        StringBuilder word = new StringBuilder();

        while (leftPointer <= rightPointer) {
            char c = s.charAt(leftPointer);

            if (c != ' ') {
                word.append(c);
            } else if (word.length() != 0 && c == ' ') {
                deque.offerFirst(word.toString());
                word.setLength(0); //reset the word for the next word
            }

            leftPointer++;
        }
        deque.offerFirst(word.toString());

        return String.join(" ", deque);

        //Space Complexity: O(n) | Time Complexity: O(n);
    }
}