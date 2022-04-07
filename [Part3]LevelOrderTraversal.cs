public class Solution {
    //Time Complexity: O(n) | Space Complexity: O(n) due to queue
    public List<List<int>> LevelOrderTraversal(BST root) {
        List<List<int>> levels = new List<List<int>>();
        if (root == null) return levels;

        Queue<BST> queue = new Queue<BST>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            int length = queue.Count;
            List<int> level = new List<int>();
            for (int i = 0; i < length; i++) {
                BST currentNode = queue.Dequeue();
                level.Add(currentNode.value);

                //Enqueue children nodes of currentNode
                if (currentNode.left != null) queue.Enqueue(currentNode.left);
                if (currentNode.right != null) queue.Enqueue(currentNode.right);
            }

            levels.Add(level);
        }

        return levels;
    }
}