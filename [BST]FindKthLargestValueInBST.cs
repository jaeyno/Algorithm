using System;
using System.Collections.Generic;

public class Program {
    public class BST {
        public int value;
        BST left;
        BST right;

        public BST(int value) {
            this.value = value;
        }
    }
    //Method 1
    //Find Kth largest value by in-order traversal
    //Time Complexity: O(n) | Space Complexity: O(n)
    public int FindKthLargestValueInOrder(BST tree, int k) {
        List<int> sortedArray = new List<int>();
        InOrderTraverse(tree, sortedArray);
        int kthLargestIndex = sortedArray.Count - k;
        return sortedArray[kthLargestIndex];
    }

    //Traverse left - value - right (it sorts from min to max in BST)
    public void InOrderTraverse(BST node, List<int> sortedArray) {
        if (node == null) {
            return;
        }
        //left
        InOrderTraverse(node.left, sortedArray);
        //value
        sortedArray.Add(node.value);
        //right
        InOrderTraverse(node.right, sortedArray);
    }


    //Method 2
    //Find Kth Largest value by reverse in-order traversal
    //Time Complexity: O(h + k) - h is height of tree & k is the input value | Space Complexity: O(h) - h is height of tree
    public int FindKthLargestValueReverseInOrder(BST tree, int k) {
        TreeInfo treeInfo = new TreeInfo(0, -1);
        ReverseInOrderTraverse(tree, k, treeInfo);
        return treeInfo.valueOfVisitedNode;
    }

    //Traverse Right - Value - Left (From max to min)
    public void ReverseInOrderTraverse(BST node, int k, TreeInfo treeInfo) {
        if (node == null | treeInfo.numberOfNodesVisited >= k) {
            return;
        }

        //right
        ReverseInOrderTraverse(node.right, k, treeInfo);

        if (treeInfo.numberOfNodesVisited < k) {
            treeInfo.numberOfNodesVisited++;
            //value
            treeInfo.valueOfVisitedNode = node.value;

            //left
            ReverseInOrderTraverse(node.left, k, treeInfo);
        }
    }

    public class TreeInfo {
        int numberOfNodesVisited;
        int valueOfVisitedNode;

        public TreeInfo(int numberOfNodesVisited, int valueOfVisitedNode) {
            this.numberOfNodesVisited = numberOfNodesVisited;
            this.valueOfVisitedNode = valueOfVisitedNode;
        }
    }
}