public class Program {
    //Time Complexity: O(n) | Space Complexity: O(1)
    public int StringCompression(char[] chars) {
        int currentIndex = 0;
        int newIndex = 0;

        while (currentIndex < chars.Length) {
            int count = 1;
            char pickedChar = chars[currentIndex];
            currentIndex++;

            while (currentIndex < chars.Length && pickedChar == chars[currentIndex]) {
                count++;
                currentIndex++;
            }

            chars[newIndex++] = pickedChar;

            if (count > 1) {
                foreach (char item in count.ToString().ToCharArray()) {
                    chars[newIndex++] = item;
                }
            }
        }

        return newIndex;
    }
}