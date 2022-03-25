public class Program {
    //Time Complexity: O(N + E) | Space Complexity: O(N)
    public List<int> DFS (List<int> array) {
        HashSet<Node> discovered = new HashSet<Node>();
        Stack<Node> stack = new Stack<Node>();

        //initialize the stack and hashset with the root node.
        stack.Push(root);
        discovered.Add(root);

        while (stack.Count > 0) {
            Node currentNode = stack.Pop();
            array.Add(currentNode.value);
            foreach (var child in currentNode.children) {
                //The node already visted will not be added to the stack
                if (!discovered.Contains(child)) {
                    stack.Push(child);
                    discovered.Add(child);
                }
            }
        }
        return array;
    }
}