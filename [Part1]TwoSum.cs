public class Solution {
    public async int[] TwoSum(int[] nums, int target) {
        //nums = [1, 2, 3, 4, 5]
        //target = x + y
        //y = target - x
        //Time Complexity: O(n) | Space Complexity: O(n)
        Dictionary<int, int> numbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int y = target - nums[i];
            if (numbers.ContainsKey(y)) {
                return new int[] {numbers[y], i};
            } else if (!numbers.ContainsKey(nums[i])) {
                numbers.Add(nums[i], i);
            }
        }
        return null;
    }
}