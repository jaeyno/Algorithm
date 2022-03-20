public class Program {
    //step 1 - remove white space
    //step 2 - determine the sign whether it is positive or negative
    //step 3 - traverse through each char and stop if we encounter non-digit char
    //step 4 - convert char to int
    //step 5 - check if the result is in the range

    //Time Complexity: O(n) | Space Complexity: O(1)
    public int AtoI(string s) {
        int result = 0;
        int sign = 1;
        int currentIndex = 0;
        int length = s.Length;

        //remove white space
        while (currentIndex < length && s[currentIndex] == ' ') {
            currentIndex++;
        }

        //determine the sign
        if (currentIndex < length && s[currentIndex] == '+') {
            sign = 1;
            currentIndex++;
        } else if (currentIndex < length && s[currentIndex] == '-') {
            sign = -1;
            currentIndex++;
        }

        //Traverse the string until non-digit char
        while (currentIndex < length && Char.IsDigit(s[currentIndex])) {
            //convert char to int
            int digit = s[currentIndex] - '0';

            //check if the result in the range
            if ((result > Int32.MaxValue / 10) || (result == Int32.MaxValue / 10 && digit > Int32.MaxValue % 10)) {
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            }

            result = 10 * result + digit;

            currentIndex++;
        }

        return sign * result;
    }
}