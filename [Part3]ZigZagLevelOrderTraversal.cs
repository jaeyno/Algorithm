public class Solution {
    //Time Complexity: O(n) | Space Complexity: O(n)
    public List<List<int>> ZigZagLevelOrderTraversal(BST root) {
        List<List<int>> levels = new List<List<int>>();
        if (root == null) return levels;

        //Create a queue
        Queue<BST> queue = new Queue<BST>();
        queue.Enqueue(root);

        bool isEvenLevel = false;
        while (queue.Count > 0) {
            int length = queue.Count;
            List<int> level = new List<int>();
            for (int i = 0; i < length; i++) {
                BST currentNode = queue.Dequeue();
                level.Add(currentNode.value);

                //Enqueue children nodes of current node
                if (currentNode.left != null) queue.Enqueue(currentNode.left);
                if (currentNode.right != null) queue.Enqueue(currentNode.right);
            }

            //if it is even level, reverse the level array
            if (isEvenLevel) {
                this.Reverse(level);
            }

            levels.Add(level);
            isEvenLevel = !isEvenLevel;
        }

        return levels;
    }

    private void Reverse(List<int> level) {
        int left = 0;
        int right = level.Count - 1;

        while (left < right) {
            int temp = level[left];
            level[left] = level[right];
            level[right] = temp;
            left++;
            right--;
        }
    }
}