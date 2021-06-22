class Solution {
    private char[][] board;
    private int rows;
    private int cols;
        
    public boolean exist(char[][] board, String word) {
        this.board = board;
        this.rows = board.length;
        this.cols = board[0].length;
        
        for (int row = 0; row < this.rows; ++row) {
            for (int col = 0; col < this.cols; ++col) {
                if (this.backtrack(row, col, word, 0)) {
                    return true;
                }
            }
        }
        return false;
    }
    
    protected boolean backtrack(int row, int col, String word, int index) {
        //step 1) check the bottom case
        if (index >= word.length()) {
            return true;
        }
        
        //step 2) check the boundaries
        if (row < 0 || row == this.rows || col < 0 || col == this.cols || this.board[row][col] != word.charAt(index)) {
            return false;
        }
        
        //step 3) explore the neighbors in DFS
        boolean ret = false;
        //mark the path before the next move
        this.board[row][col] = '#';
        
        int[] rowOffSets = {0, 1, 0, -1};
        int[] colOffSets = {1, 0, -1, 0};
        for (int dir = 0; dir < 4; ++dir) {
            ret = this.backtrack(row + rowOffSets[dir], col + colOffSets[dir], word, index + 1);
            if (ret) {
                break;
            }
        }
        
        //step 4) clean up and return the result
        this.board[row][col] = word.charAt(index);
        return ret;
    }
    //time O(N * 3^L) | space O(L)
}