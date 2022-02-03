using System;

public class Program {
    public class BST {
        public int value;
        public BST left;
        public BST right;

        public BST(int value) {
            this.value = value;
        }
    }

    public static bool ValidateBST(BST tree) {
        return ValidateBST(tree, Int32.MinValue, Int32.MaxValue);
    }

    //Time Complexity: O(n) | Space Complexity: O(d) *d is depth of the tree
    public static bool ValidateBST(BST tree, int minValue, int maxValue) {
        if (tree.value < minValue || tree.value >= maxValue) {
            return false;
        }

        if (tree.left != null && !ValidateBST(tree.left, minValue, tree.value)) {
            return false;
        }

        if (tree.right != null && !ValidateBST(tree.right, tree.value, maxValue)) {
            return false;
        }

        return true;
    }
}