public class Program {
    //Time Complexity: O(log(n)) | Space Complexity: O(1)
    public int FindMinInRotatedArray(int[] nums) {
        if (nums.Length == 1) {
            return nums[0];
        }

        int left = 0;
        int right = nums.Length - 1;

        //Check if nums is rßotated array
        //If it is not a rotated array, return the first element
        if (nums[right] > nums[0]) {
            return nums[0];
        }

        //Binary Search
        while (right > left) {
            int mid = left + (right - left) / 2;

            //If mid is greater than its next element, then mid + 1 is the smallest number
            if (nums[mid] > nums[mid + 1]) {
                return nums[mid + 1];
            }

            //If mid is less than its previous, then mid is the smallest
            if (nums[mid] < nums[mid - 1]) {
                return nums[mid];
            }

            //If mid is greater than first element, inflection point is on right
            if (nums[mid] > mid[0]) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return -1;
    }
}