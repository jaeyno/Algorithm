public class Program {
    //Time Complexity: O(log(n)) | Space Complexity: O(1)
    public int FindMinInRotatedArray(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        //check if array is rotated array
        if (nums[right] > nums[0]) {
            return nums[0];
        }

        //Binary Search on rotated array
        while (right > left) {
            int mid = left + (right - left) / 2;

            //if mid is greater than its next element, then mid + 1 is the smallest number [4, 5, 6, 7(mid), 2, 3]
            if (nums[mid] > nums[mid + 1]) {
                return nums[mid + 1];
            }

            //if mid is less than its previous, then mid is the smallest [4, 5, 6, 7, 2(mid), 3]
            if (nums[mid] < nums[mid - 1]) {
                return nums[mid];
            }

            if (nums[mid] > nums[0]) {
                left = mid + 1; //if mid is greater than first element, inflection point is on right
            } else {
                right = mid; //if mid is less than first element, inflection point is on left
            }
        }

        return -1;
    }
}