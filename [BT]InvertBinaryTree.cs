public class Program {
    public class BinaryTree {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value) {
            this.value = value;
            left = null;
            right = null;
        }
    }

    //Time Complexity: O(n) | Space Complexity: O(d) - d is depth of binary tree
    public BinaryTree InvertBinaryTree(BinaryTree tree) {
        if (tree == null) return;

        swapLeftandRightNode(tree);
        InvertBinaryTree(tree.left);
        InvertBinaryTree(tree.right);
    }

    private void swapLeftandRightNode(BinaryTree tree) {
        BinaryTree temp = tree.left;
        tree.left = tree.right;
        tree.right = temp;
    }
}