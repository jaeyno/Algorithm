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

    //Pre-Order Traversal: Current - Left - Right
    //Time Complexity: O(n) | Space Complexity: O(n)
    public List<int> PreOrderTraverse(BST tree, List<int> array) {
        array.Add(tree.value);
        if (tree.left != null) {
            PreOrderTraverse(tree.left, array);
        }
        if (tree.right != null) {
            PreOrderTraverse(tree.right, array);
        }
        return array;
    }

    //In-Order Traversal: Left - Current - Right
    //Time Complexity: O(n) | Space Complexity: O(n)
    public List<int> InOrderTraverse(BST tree, List<int> array) {
        if (tree.left != null) {
            InOrderTraverse(tree.left, array);
        }
        array.Add(tree.value);
        if (tree.right != null) {
            InOrderTraverse(tree.right, array);
        }
        return array;
    }

    //Post-Order Traversal: Left - Right - Current
    //Time Complexity: O(n) | Space Complexity: O(n)
    public List<int> PostOrderTraverse(BST tree, List<int> array) {
        if (tree.left != null) {
            PostOrderTraverse(tree.left, array);
        }
        if (tree.right != null) {
            PostOrderTraverse(tree.right, array);
        }
        array.Add(tree.value);
        return array;
    }
}