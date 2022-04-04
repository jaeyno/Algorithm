public class Solution {
    //Time Complexity: O(r * c) | Space Complexity: O(r + c)
    public async void SetZeros(int[][] matrix) {
        int r = matrix.Length;
        int c = matrix[0].Length;
        HashSet<int> rows = new HashSet<int>();
        HashSet<int> cols = new HashSet<int>();

        //Store the row and column index of the element that is zero
        for (int i = 0; i < r; i++) {
            for (int j = 0; j < c; j++) {
                if (matrix[i][j] == 0) {
                    rows.Add(i);
                    cols.Add(j);
                }
            }
        }

        //Change the element that needs to be zero
        for (int i = 0; i < r; i++) {
            for (int j = 0; j < c; j++) {
                if (rows.ContainsKey(i) || cols.ContainsKey(j)) {
                    matrix[i][j] = 0;
                }
            }
        }
    }
}