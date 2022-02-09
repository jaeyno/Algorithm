public class Program {

    public class BinaryTree {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value) {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }

    //Time Complexity: O(n) | Space Complexity: O(n)
    public List<int> BranchSum(BinaryTree root) {
        List<int> sums = new List<int> ();
        CalculateBranchSum(root, 0, sums);
        return sums;
    }

    public void CalculaterBranchSum(BinaryTree node, int runningSum, List<int> sums) {
        if (node == null) return;
        
        int newRunningSum = runningSum + node.value;
        
        if (node.left == null && node.right == null) {
            sums.Add(newRunningSum);
            return;
        }

        CalculaterBranchSum(node.left, newRunningSum, sums);
        CalculaterBranchSum(node.right, newRunningSum, sums);
    }

}