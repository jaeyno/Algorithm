public class LinkedList {
    public int value;
    public LinkedList next = null;

    public LinkedList(int value) {
        this.value = value;
    }

    //Time Complexity: O(n) | Space Complexity: O(n) - because we are using hashset to store all the nodes.
    public bool HasCycle(LinkedList head) {
        HashSet<LinkedList> existingNodes = new HashSet<LinkedList>();
        while (head != null) {
            if (existingNodes.Contains(head)) {
                return true;
            }
            existingNodes.Add(head);
            head = head.next;
        }
        return false;
    }
}