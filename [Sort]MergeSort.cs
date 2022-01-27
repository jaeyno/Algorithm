public class Program {
    public static int[] MergeSort(int[] array) {
        //an array that contains only one element is a sorted array
        if (array.Length <= 1) {
            return array;
        }
        //clone a array
        int[] clonedArray = (int[])array.Clone();

        //recursion
        MergeSort(start, end, array, clonedArray);

        return array;
    }

    //overload the method, MergeSort
    public static void MergeSort(int start, int end, int[] mainArray, int[] clonedArray) {
        //exit condition when there is only one element in an array
        if (start == end) {
            return;
        }

        int middle = (start + end) / 2;
        //recursion on the left side
        //pass the clonedArray as mainArray & the mainArray as clonedArray
        MergeSort(start, middle, clonedArray, mainArray);
        
        //same recursion process on the right side
        MergeSort(middle + 1, end, clonedArray, mainArray);

        //merge the subarrays
        Merge(start, middle, end, mainArray, clonedArray);
    }

    public static void Merge(int start, int middle, int end, int[] mainArray, int[] clonedArray) {
        int mainStart = start;
        int leftStart = start;
        int rightStart = middle + 1;

        //compare each element from left side with the element from right side
        while (leftStart <= middle && rightStart <= end) {
            if (clonedArray[leftStart] <= clonedArray[rightStart]) {
                mainArray[mainStart++] = clonedArray[leftStart++];
            } else {
                mainArray[mainStart++] = clonedArray[rightStart++];
            }
        }

        //if there is left over elements in left side
        while (leftStart <= middle) {
            mainArray[mainStart++] = clonedArray[leftStart++];
        }

        //if there is left over elements in right side
        while (rightSide <= end) {
            mainArray[mainStart++] = clonedArray[rightStart++];
        }
    }
}
//Time Complexity: O(NLog(N)) | Space Complexity: O(N) | Stability: Yes