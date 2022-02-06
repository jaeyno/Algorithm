public class Program {
    public class BST {
        int value;
        public BST left;
        public BST right;

        public BST(int value) {
            this.value = value;
            left = null;
            right = null;
        }
    }

    //Time Complexity: O(log(n))
    public void Insert(int value) {
        if (value < this.value) {
            if (left == null) {
                left = new BST(value);
            } else {
                left.Insert(value);
            }
        } else {
            if (right == null) {
                right = new BST(value);
            } else {
                right.Insert(value);
            }
        }
    }

    public BST MinHeightBST(List<int> array) {
        return ConstructMinHeightBST(array, null, 0, arrray.Count - 1);
    }

    //Time Complexity: O(nlog(n)) - log(n) due to insert | Space Complexity: O(n) - where n is the length of the array
    public BST ConstructMinHeightBST(List<int> array, BST bst, int startIndex, int endIndex) {
        if (endIndex < startIndex) return null;
        int midIndex = (startIndex + endIndex) / 2;
        int valueToAdd = array[midIndex];
        if (bst == null) {
            bst = new BST(valueToAdd);
        } else {
            bst.Insert(valueToAdd);
        }
        //left subtree
        ConstructMinHeightBST(array, bst, startIndex, midIndex - 1);
        ConstructMinHeightBST(array, bst, midIndex + 1, endIndex);
        return bst;
    }

    //Without using Insert method
    //Time Complexity: O(n) | Space Complexity: O(n) - where n is the length of the array
    public BST ConstructMinHeightBST(List<int> array, int startIndex, int endIndex) {
        if (endIndex < startIndex) return null;
        int midIndex = (startIndex + endIndex) / 2;
        BST bst = new BST(array[midIndex]);
        bst.left = ConstructMinHeightBST(array, startIndex, midIndex - 1);
        bst.right = ConstructMinHeightBST(array, midIndex + 1, endIndex);
        return bst;
    }
}