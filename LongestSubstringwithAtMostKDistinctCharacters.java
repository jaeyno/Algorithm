class Solution {
    public int lengthOfLongestSubstringKDistinct(String s, int k) {
        //length of string
        int n = s.length();

        //When a single character is given when k = 0;
        if (n * k == 0) {
            return 0;
        }

        //left & right pointer
        int left = 0;
        int right = 0;

        //create a hash map to store each character of the given string
        Map<Character, Integer> hashMap = new HashMap<>();

        int maxLength = 1;

        while (right < n) {
            //store the character of string and its index;
            hashMap.put(s.charAt(right), right++);

            if (hashMap.size() == k + 1) {
                //find the index of the most left character in the hash map
                int theMostLeft = Collections.min(hashMap.values());
                //remove the most left character in the hash map to make the size of k is equal to the given k
                hashMap.remove(s.charAt(theMostLeft));
                //move the left pointer by 1
                left = theMostLeft + 1;
            }
            //store the longest substring with at most k 
            maxLength = Math.max(maxLength, right - left);
        }
        return maxLength;
    }
}