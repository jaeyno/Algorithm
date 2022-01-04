public class Program {
    public static int ProductSum(List<object> array) {
        return ProductSumHelper(array, 1);
    }

    public static int ProductSumHelper(List<object> array, int multiplier) {
        int sum = 0;
        foreach(object el in array) {
            if (el is List<object>) {
                sum += ProductSumHelper((List<object>)el, multiplier + 1);
            } else {
                sum += (int)el;
            }
        }
        return sum * multiplier;
    }
}