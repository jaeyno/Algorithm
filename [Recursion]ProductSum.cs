public class Program {
    public static int ProductSum(List<object> array) {
        return ProductSumHelper(array, 1);
    }

    public static int ProductSumHelper(List<object> array, int multiplier) {
        int sum = 0;

        foreach (object item in array) {
            // check if the item is special array - array in array
            if (item is List<object>) {
                sum += ProductSumHelper((List<object>)item, multiplier + 1);
            } else {
                sum += (int)item;
            }
        }

        return sum * multiplier;
    }
    //Time Complexity: O(n) | Space Complexity: O(n)
}