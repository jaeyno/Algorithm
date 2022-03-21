public class Program {
    public int StringCompression(char[] chars) {
        //step 1 pick one char to compare with
        //step 2 if the picked char is equal to next chars, increase count and move to next char
        //step 3 if the picked char is not equal to the next char
        //step 4 pick the next char and repeat 2 and 3
        int start = 0;
        int newStart = 0;

        while (start < chars.Length) {
            int count = 1;
            char pickedChar = chars[start];
            while (start < chars.Length && pickedChar == chars[start]) {
                count++;
                start++;
            }

            chars[newStart++] = pickedChar;

            if (count > 1) {
                //convert int to char
                foreach (char item in count.ToString().ToCharArray()) {
                    chars[newStart++] = item;
                }
            }
        }

        return newStart;
    }
}