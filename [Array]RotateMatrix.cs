public class Solution {
    //Time Complexity: O(n) | Space Complexity: O(1)
    public void RotateMatrix(int[][] matrix) {
        this.Transpose(matrix);
        this.Reflect(matrix);
    }
 
   private void Transpose(int[][] matrix) {
       int n = matrix.Length;
       for (int i = 0; i < n; i++) {
           for (int j = i + 1; j < n; j++) {
                int temp = matrix[j][i];
                matrix[j][i] = matrix[i][j];
                matrix[i][j] = temp;
           }
       }
   }

   private void Reflect(int[][] matrix) {
       int n = matrix.Length;
       for (int i = 0; i < n; i++) {
           for (int j = 0; j < (n / 2); j++) {
               int temp = matrix[i][j];
               matrix[i][j] = matrix[n - j - 1];
               matrix[n - j - 1] = temp;
           }
       }
   }
}