public class Program {
    public class BST {
        public int value;
        public BST left;
        public BST right;

        public BST(int value) {
            this.value = value;
        }
    }

    //Time Complexity: O(n) | Space Complexity: O(n)
    //In-order traversal in bst willl give a sorted array in ascending order
    public int FindKthLargestValueInBST(BST tree, int k) {
        List<int> sortedArray = new List<int>();
        InOrderTraverse(tree, sortedArray);
        return sortedArray[sortedArray.Count - k];
    }

    private void InOrderTraverse(BST tree, List<int> sortedArray) {
        if (tree.left != null) {
            InOrderTraverse(tree.left, sortedArray);
        }

        sortedArray.Add(tree.value);

        if (tree.right != null) {
            InOrderTraverse(tree.right, sortedArray);
        }

        return sortedArray;
    }
}