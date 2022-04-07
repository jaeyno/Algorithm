public class Solution {
    //DFS: Left - Node - Right
    //Time Complexity: O(n) | Space Complexity: O(d)
    public List<int> InorderTraversal(BST root) {
        List<int> array = new List<int>();
        return InorderTraversalDFS(root, array);
    }

    private List<int> InorderTraversalDFS(BST root, List<int> array) {
        //Exit Condition
        if (root == null) return array;

        //Left
        if (root.left != null) {
            InorderTraversalDFS(root.left, array);
        }

        //Node
        array.Add(root.value);

        //Right
        if (root.right != null) {
            InorderTraversalDFS(root.right, array);
        }

        return array;
    }
}