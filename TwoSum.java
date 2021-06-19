class Solution {
    public int[] twoSum(int[] nums, int target) {
        //crate a hash map
        Map<Integer, Integer> hashMap = new HashMap<>();

        //iterate the int[] nums while putting the element into hashmap
        for (int i = 0; i < nums.length; i++) {
            int num1 = target - nums[i];
            if (hashMap.containsKey(num1)) {
                return new int[] {hashMap.get(num1), i};
            }
            hashMap.put(nums[i], i);
        }
        return null;
     }
}