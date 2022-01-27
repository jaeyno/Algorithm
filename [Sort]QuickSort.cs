public class Program {
    public static int[] QuickSort(int[] array) {
        QuickSort(start, end, array);
        return array;
    }

    //overload the method, QuickSort()
    public static void QuickSort(int start, int end, int[] array) {
        //if an array has only one element, finish the recursion.
        if (start >= end) {
            return;
        }

        int pivot = start;
        int left = start + 1;
        int right = end;

        while (right >= left) {
            //if pivot value is smaller than left value and greater than right value
            if (array[left] > array[pivot] && array[right] < array[pivot]) {
                Swap(left, right, array);
            }

            //if pivot value is greater than or equal to left value, move the left pointer to right by 1 index
            if (array[left] <= array[pivot]) {
                left++;
            }

            //if pivot value is smaller than or equal to right value, move the right pointer to left by 1 index
            if (array[right] >= array[pivot]) {
                right--;
            }
        }
        //Switch the pivot value with the right value
        Swap(pivot, right, array);

        //Find the which subarray is smaller to optimize the space complexity due to recursion
        bool isLeftSubArraySmaller = (right - 1) - start < end - (right + 1);
        if (isLeftSubArraySmaller) {
            QuickSort(start, right - 1, array);
            QuickSort(right + 1, end, array);
        } else {
            QuickSort(right + 1, end, array);
            QuickSort(start, right - 1, array);
        }
    }

    public static void Swap(int i, int j, int[] array) {
        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
}
//Average Time Complexity: O(NLog(N)) | Space Complexity: O(Log(N)) | Stability: No
//Wortst Time Complexity: O(N^2) | Space Complexity: O(N^2)