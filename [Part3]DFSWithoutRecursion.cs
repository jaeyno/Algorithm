public class Solution {
    //Node - Left - Right
    public List<int> PreorderTraversal(BST root) {
        List<int> result = new List<int>();
        Stack<BST> stack = new Stack<BST>();
        stack.Push(root);
        
        while (stack.Count > 0) {
            BST currentNode = stack.Pop();
            result.Add(currentNode.value);

            if (currentNode.right != null) stack.Push(currentNode.right);
            if (currentNode.left != null) stack.Push(currentNode.left);
        }

        return result;
    }

    public List<int> InorderTraversal(BST root) {
        List<int> result = new List<int>();
        Stack<BST> stack = new Stack<BST>();
        BST currentNode = root;

        while (stack.Count > 0 || currentNode != null) {
            while (currentNode != null) {
                stack.Push(currentNode);
                currentNode = currentNode.left;
            }

            currentNode = stack.Pop();
            result.Add(currentNode.value);
            currentNode = currentNode.right;
        }

        return result;
    }
}