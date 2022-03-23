public class Program {
    public class BST {
        public int value;
        public BST left;
        public BST right;

        public BST(int value) {
            this.value = value;
        }
    }

    //Time Complexity: O(log(n)) | Space Complexity: O(log(n)) because we are using recursion and using call stack
    //Worst Time Complexity: O(n) | Space Complexity: O(n)
    public int FindClosestValueInBST(BST tree, int target) {
        return this.FindClosestValueInBST(tree, target, tree.value);
    }

    private int FindClosestValueInBST(BST tree, int target, int closest) {
        //find the closest value in the tree
        if (Math.Abs(target - closest) > Math.Abs(target - tree.value)) {
            closest = tree.value;
        }

        //if target is smaller than tree value, go to left subtree else if target is greater than tree value, traverse to right subtree
        if (target < tree.value && tree.left != null) {
            return FindClosestValueInBST(tree.left, target, closest);
        } else if (target > tree.value && tree.right != null) {
            return FindClosestValueInBST(tree.right, target, closest);
        } else {
            return closest;
        }
    }
}