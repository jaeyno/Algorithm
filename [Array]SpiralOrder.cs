public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        //Initialize variables
        List<int> result = new List<int>();
        int r = matrix.Length;
        int c = matrix[0].Length;
        int top = 0;
        int bottom = r - 1;
        int left = 0;
        int right = c - 1;

        while (result.Count < r * c) {
            //Traverse from left to right
            for (int col = left; col <= right; col++) {
                result.Add(matrix[top][col]);
            }

            //Traverse from top to bottom
            for (int row = top + 1; row <= bottom; row++) {
                result.Add(matrix[row][right]);
            }

            //Traverse from right to left
            if (top != bottom) {
                for (int col = right - 1; col >= left; col--) {
                    result.Add(matrix[bottom][col]);
                }
            }

            //Traverse from bottm to top
            if (left != right) {
                for (int row = bottom -1; row > top; row--) {
                    result.Add(matrix[row][left]);
                }
            }


            top++;
            bottom--;
            left++;
            right--;
        }

        return result;
    }
}