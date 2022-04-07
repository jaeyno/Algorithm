public class Solution {
    public class BST {
        public int value;
        public BST left;
        public BST right;
        public BST(int value = 0, BST left = null, BST right = null) { 
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }

    //Time Complexity: O(n) | Space Complexity: O(d) due to recursion - d is depth of tree
    public bool IsValidBST(BST root) {
        return IsValidBST(root, Int32.MinValue, Int32.MaxValue);
    }

    public bool IsValidBST(BST root, int minValue, int maxValue) {
        //Exit Condition for Recursion
        if (root == null) return true;

        //For left subtree, it should be greater than minValue, but less than root.value
        //For right subtree, it should be less than maxValue, but greater than root.value
        if (root.value <= minValue || root.value >= maxValue) {
            return false;
        }

        return IsValidBST(root.left, minValue, root.value) && IsValidBST(root.right, root.value, maxValue);
    }
}