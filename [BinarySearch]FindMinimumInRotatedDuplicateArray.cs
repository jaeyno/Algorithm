public class Program {
    //Time Complexity: O(log(n)) - Worst Case: O(n) | Space Complexity: O(1)
    public int FindMinInRotatedDuplicateArray(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] > nums[right]) {
                left = mid + 1;
            } else if (nums[mid < nums[right]]) {
                right = mid;
            } else {
                right--;
            }
        }

        return nums[left];
    }
}