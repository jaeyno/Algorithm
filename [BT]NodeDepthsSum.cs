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

    //Time Complexity: O(n) - n is number of nodes| Space Complexity: O(h) - h is height of binary tree
    public int SumNodeDepths(BinaryTree root) {
        return SumNodeDepths(root, 0);
    }

    public int SumNodeDepths(BinaryTree root, int depth) {
        if (root == null) return 0;
        return depth + SumNodeDepths(root.left, depth + 1) + SumNodeDepths(root.right, depth + 1);
    }
}