public class Program {
    public class BST {
        public int value;
        public BST left;
        public BST right;

        public BST(int value) {
            this.value = value;
        }
    }

    //To be valid binary search tree
    //left subtree should contain only nodes less than its parent node
    //right subtree should contain only nodes greather  than its parent node.
    //for the left subtree so we need to compare each child node with the parentNode if it is less than parentNode or not
    //if it is less than that, return true otherwise return false
    // I will overload the function, ValidateBST by passing two additional params such as minValue and maxValue.
    // To check left subtree, maxValue will be the tree.value
    // To check right subtree, minValue will be the tree.value

    //Time Complexity: O(n) | Space Complexity: O(d) due to call stack
    public bool ValidateBST(BST tree) {
        return ValidateBST(tree, null, null);
    }

    public bool ValidateBST(BST tree, int? minValue, int? maxValue) {
        //exit condition of recursion
        if (tree.value == null) {
            return true;
        }

        //should satisfy this range to be true
        if (tree.value <= minValue || tree.value >= maxValue) {
            return false;
        }

        return ValidateBST(tree.left, minValue, tree.value) && ValidateBST(tree.right, tree.value, maxValue);
    }
}