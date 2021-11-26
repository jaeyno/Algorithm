using System;

public class Program {
    public static int BinarySearch(int[] array, int target) {
        //using a overloaded recursive function
        return BinarySearch(array, target, 0, array.Length);
    }

    public static int BinarySearch(int[] array, int target, int left, int right) {
        //exit condition
        if (left > right) {
            return -1;
        }

        int middle = (left + right) / 2;
        int potentialMatch = array[middle];

        if (potentialMatch == target) {
            return middle;
        } else if (potentialMatch > target) {
            return BinarySearch(array, target, left, middle - 1);
        } else {
            return BinarySearch(array, target, middle + 1, right);
        }
    }
}