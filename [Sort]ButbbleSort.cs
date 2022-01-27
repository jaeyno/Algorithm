public class Program {
    public static int[] BubbleSort(int[] array) {
        //defensive code
        if (array.Length == 0) {
            return new int[] {};
        }

        bool isSorted = false;
        int counter = 0;

        while (!isSorted) {
            isSorted = true;
            for (int i = 0; i <= array.Length - 1 - counter; i++) {
                if (array[i] > array[i + 1]) {
                    Swap(i, i + 1, array);
                    isSorted = false;
                }
            }
            counter++;
        }
        return array;
    }

    public static void Swap(int i, int j, int[] array) {
        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
}
// Time Complexity: O(N^2) | Space Complexity: O(1) | Stability: Yes