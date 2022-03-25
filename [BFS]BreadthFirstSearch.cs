public class Program {
    //Time Complexity: O(N + E) | Space Complexity: O(N)
    public List<int> BFS (List<int> array) {
        Queue<Node> queue = new Queue<Node>();
        
        //initialize the queue with the root node;
        queue.Enqueue(root);
        
        while (queue.Count > 0) {
            Node currentNode = queue.Dequeue();
            array.Add(currentNode);
            foreach (var child in currentNode.children) {
                queue.Enqueue(child);
            }
        }

        return array;
    }
}