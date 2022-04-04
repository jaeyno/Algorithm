public class Solution {
    //Time Complexity: O(n) | Space Complexity: O(1)
    public int Atoi(string s) {
        int result = 0;
        int sign = 1;
        int currentIndex = 0;
        int length = s.Length;

        //remove the leading white space
        while (currentIndex < length && s[currentIndex] == ' ') {
            currentIndex++;
        }

        //determine the sign
        if (currentIndex < length && s[currentIndex] == '+') {
            currentIndex++;
        } else if (currentIndex < length && s[currentIndex] == '-') {
            sign = -1;
            currentIndex++;
        }

        //move until non-digit char is met
        while (currentIndex < length && Char.IsDigit(s[currentIndex])) {
            //convert char to int
            int digit = s[currentIndex] - '0';

            //check if the result in the range
            if ((result > Int32.MaxValue / 10) || (result == Int32.MaxValue / 10 && digit > Int32.MaxValue % 10)) {
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            }

            //Append digit to the result
            result = result * 10 + digit;

            currentIndex++;
        }

        return sign * result;
    }
}