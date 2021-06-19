class Solution {
    public int firstMissingPositive(int[] nums) {
        int n = nums.length;

        //check if there is 1 in the given array
        int presenceofNumberOne = 0;
        for (int i = 0; i < n; i++) {
            if (nums[i] == 1) {
                presenceofNumberOne++;
                break;
            }
        }

        //if there is no 1 in the given array, return 1 as the possible smallest positive integer
        if (presenceofNumberOne == 0) {
            return 1;
        }

        //if there is 1 in the given array, replace all the negative integers, 0 and interger larger than n with 1;
        //because the max possible integer will be n+1. for example, if the length of the given array is 5, [1, 2, 3, 4, 5] => 6
        for (int i = 0; i < n; i++) {
            if (nums[i] <= 0 || nums[i] > n) {
                nums[i] = 1;
            }
        }

        //if nums[1] is negative, it means 1 is present in the given array
        //if nums[2] is positive, it means 2 is not present in the given array
        for (int i = 0; i < n; i++) {
            int a = Math.abs(nums[i]);

            //n is the max integer if it is present 
            if (a == n) {
                nums[0] = - Math.abs(nums[0]);
            } else {
                nums[a] = - Math.abs(nums[a]);
            }
        }

        for (int i = 1; i < n; i++) {
            if (nums[i] > 0) {
                return i;
            }
        }

        if (nums[0] > 0) {
            return n;
        }

        return n + 1;
    }
}