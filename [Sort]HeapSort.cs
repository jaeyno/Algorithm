public class Program {
    public static int[] HeapSort(int[] array) {
        //Build Max Heap first
        BuildMaxHeap(array);
        for (int endIndex = array.Length - 1; endIndex > 0; endIndex--) {
            //Swap the first element of max heap array with the endIndex-- of the whole array
            Swap(0, endIndex, array);
            //Sift Down on the first element which has been swapped with the endIndex-- 
            SiftDown(0, endIndex - 1, array);
        }
        return array;
    }

    public static void BuildMaxHeap(int[] array) {
        //Start building from the most left-bottom parent node
        int parentIndex = ((array.Length - 1) - 1) / 2;
        for (int currentIndex = parentIndex; currentIndex >= 0; currentIndex--) {
            SiftDown(currentIndex, array.Length - 1, array);
        }
    }

    public static void SiftDown(int currentIndex, int endIndex, int[] array) {
        int firstChildIndex = (2 * currentIndex) + 1;
        while (firstChildIndex <= endIndex) {
            int secondChildIndex = (2 * currentIndex) + 2 <= endIndex ? (2 * currentIndex) + 2 : -1;
            int indexToSwap;
            
            if (secondChildIndex != -1 && array[secondChildIndex] > array[firstChildIndex]) {
                indexToSwap = secondChildIndex;
            } else {
                indexToSwap = firstChildIndex;
            }

            if (array[indexToSwap] > array[currentIndex]) {
                Swap(currentIndex, indexToSwap, array);
                currentIndex = indexToSwap;
                firstChildIndex = (2 * currentIndex) + 1;
            } else {
                return;
            }
        }
    }

    Swap(int i, int j, int[] array) {
        int temp = array[j];
        array[j] = array[i];
        array[j] = temp;
    }
}
//Time Complexity: O(nlog(n)) | Space Complexity: O(1) | Stability: No