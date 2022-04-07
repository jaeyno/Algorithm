public class BST {
    int value;
    BST left;
    BST right;
    BST next;
    public BST(int value, BST left = null, BST right = null, BST next = null) {
        this.value = value;
        this.left = left;
        this.right = right;
        this.next = next;
    }
}

public class Solution {
    //Time Complexity: O(n) | Space Complexity: O(n)
    public BST ConnectToNextNode(BST root) {
        //Using BSF to connect to the next node
        if (root = null) return root;

        Queue<BST> queue = new Queue<BST>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            int length = queue.Count;
            for (int i = 0; i < length; i++) {
                BST currentNode = queue.Dequeue();
                
                //Connect to next node except the last node
                if (i < length - 1) {
                    currentNode.next = queue.Peek();
                }

                //Enqueue chidlren nodes
                if (currentNode.left != null) queue.Enqueue(currentNode.left);
                if (currentNode.right != null) queue.Enqueue(currentNode.right);
            }
        }

        return root;
    }
}