public class Program {
    //input: "raceacar" | output: false
    //There will be non-alphanumeric characters
    //need to remove non-alhanumeric characters before comparing

    //step 1: i will travers from both end by making two pointers
    //step 2: remove any non-alphanumeric characters if it exists
    //step 3: Before comparing two characters, convert them to lowercase just in case
    //step 4: Compare two characters. it is is equal to each other, keep traversing. if not, return false;

    //Time Complexity: O(n) | Space Complexity: O(1)
    public bool IsPalindrom(string s) {
        int start = 0;
        int end = s.Length - 1;

        while (start < end) {
            //remove non-alphanumeric characters for start pointer and end pointer
            if (!Char.IsLetterOrDigit(s[start])) {
                start++;
                continue;
            }
            if (!Char.IsLetterOrDigit(s[end])) {
                end--;
                continue;
            }

            //compare two characters whether it is equal to each other
            if (Char.ToLower(s[start] != Char.ToLower(s[end]))) {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }
}