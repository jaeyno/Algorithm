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

    //Solution 1 - using recursion
    //Average Time Complexity: O(log(n)) | Space Complexity: O(log(n))
    //Worst Time Complexity: O(n) due to linked list| Space Complexity: O(n)
    public static int FindClosestValue(BST tree, int target, string method = "recursion") {
        if (method == "recursion") {
            return FindClosestValueRecursive(tree, target, tree.value);
        } else {
            return FindClosestValueIteration(tree, target, tree.value);
        }
    }

    public static int FindClosestValueRecursive(BST tree, int target, int closest) {
        if (Math.Abs(target - closest) > Math.Abs(target - tree.value)) {
            closest = tree.value;
        }
        //if target is smaller than tree.value -> go to left subtree
        if (target < tree.value && tree.left != null) {
            FindClosestValueRecursive(tree.left, target, closest);
        } else if (target > tree.value && target.right != null) {
            FindClosestValueRecursive(tree.right, target, closest);
        } else {
            return closest;
        }
    }

    //Average Time Complexity: O(log(n)) | Space Complexity: O(1)
    //Worst Time Complexity: O(n) due to linked list | Space Complexity: O(1)
    public static int FindClosestValueIteration(BST tree, int target, int closest) {
        BST currentNode = tree;
        while (currentNode != null) {
            if (Math.Abs(target - closest) > Math.Abs(target - currentNode.value)) {
                closest = currentNode.value;
            }
            if (target < currentNode.value) {
                currentNode = currentNode.left;
            } else if (target > currentNode.right) {
                currentNode = currentNode.right;
            } else {
                break;
            }
        }
        return closest;
    }
}