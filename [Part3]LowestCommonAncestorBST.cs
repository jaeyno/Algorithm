public class Solution {
    public BST LowestCommonAncestorBST(BST root, BST p, BST q) {
        int pValue = p.value;
        int qValue = q.value;

        //when split occur, the current node is the lowest common ancestor
        while (root != null) {
            int rootValue = root.value;
            if (pValue < rootValue && qValue < rootValue) {
                root = root.left;
            } else if (pValue > rootValue && qValue > rootValue) {
                root = root.right;
            } else {
                return root;
            }
        }

        return root;
    }
}