using System;

public class Program {
    public int[] sortedSquaredArray(int[] sortedArray) {

        //empty array to store the squared array
        int[] emptySquaredArray = new int[sortedArray.Length];

        //left & right pointer
        int left = 0;
        int right = sortedArray.Length - 1;

        for (int i = sortedArray.Length - 1; i >= 0; i--) {
            int leftNum = Math.Abs(sortedArray[left]);
            int rightNum = Math.Abs(sortedArray[right]);

            if (leftNum > rightNum) {
                emptySquaredArray[i] = leftNum * leftNum;
                left++;
            } else {
                emptySquaredArray[i] = rightNum * rightNum;
                right--;
            }
        }

        return emptySquaredArray;
    }
}

//Time complexity is O(n) & Space complexity is O(n)
//this method is only possible because the input array is sorted.