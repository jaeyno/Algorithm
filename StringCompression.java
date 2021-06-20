class Solution {
    public int compress(char[] chars) {
        int index = 0;
        int indexAns = 0;

        while (index < chars.length) {
            char currentChar = chars[index];

            int count = 0;
            while (index < chars.length && currentChar == chars[index]) {
                index++;
                count++;
            }

            chars[indexAns++] = currentChar;

            if (count != 1) {
                //if count is larger than or equal to 10 => '1','0'
                for (char c : Integer.toString(count).toCharArray()) {
                    chars[indexAns++] = c;
                }
            }
        }
        return indexAns;
    }
}