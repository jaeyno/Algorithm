public class LinkedList {
    public int value;
    public LinkedList next = null;
    public LinkedList random = null;

    public LinkedList(int value) {
        this.value = value;
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList CopyRandomList(LinkedList head) {
        LinkedList currentNode = head;

        //copy a currentNode and insert the copied node next to its currentNode
        //A-B-C => A-A'-B-B'-C-C'
        while (currentNode != null) {
            LinkedList clonedNode = new LinkedList(currentNode.value);
            clonedNode.next = currentNode.next;
            currentNode.next = clonedNode;
            currentNode = clonedNode.next;
        }

        //link the random pointers of cloned list
        currentNode = head;
        while (currentNode != null) {
            currentNode.next.random = currentNode.random != null ? currentNode.random.next : null;
            currentNode = currentNode.next.next;
        }

        //detach the cloned list
        LinkedList original = head;
        LinkedList cloned = head.next;
        LinkedList clonedList = head.next;

        while (original != null) {
            original.next = original.next.next;
            cloned.next = cloned.next != null ? cloned.next.next : null;
            original = original.next;
            cloned = cloned.next;
        }
        return clonedList;
    }
}