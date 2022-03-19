public class Program {

    //Time Complexity: O(n) | Space Complexity: O(n)
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numbers = new Dictionary<int, int> ();

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