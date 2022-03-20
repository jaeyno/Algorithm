public class Program {
    //step 1 - remove the white spaces
    //step 2 - determine the sign whether it is positive or negative
    //step 3 - convert to int from char if next index is not digit, stop
    //step 4 - check if it is overflow or underflow of the range

    //Time Complexity: O(n) | Space Complexity: O(1)
    public int MyAtoI(string s) {
        int result = 0;
        int sign = 1;
        int currentIndex = 0;
        int length = s.Length;

        //remove white spaces
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

        //Traverse each element until non-digit character
        while (currentIndex < length && Char.IsDigit(s[currentIndex])) {
            //convert from char to int
            int digit = s[currentIndex] - '0';

            //check overflow and underflow condition
            if ((result > Int32.MaxValue / 10) || (result == Int32.MaxValue / 10 && digit > Int32.MaxValue % 10)) {
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            }

            result = 10 * result + digit;

            currentIndex++;
        }

        return sign * result;
    }
}