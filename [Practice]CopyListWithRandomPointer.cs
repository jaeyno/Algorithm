public class Program {
    public class LinkedList {
        public int value;
        public LinkedList next = null;
        public LinkedList random = null;

        public LinkedList(int value) {
            this.value = value;
        }
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList CopyRandomList(LinkedList head) {
        //clone a original node and insert a cloned node next to its original node
        //A - B - C => A - A' - B - B' - C - C'
        LinkedList currentnode = head;
        while (currentnode != null) {
            LinkedList clonedNode = new LinkedList(currentnode.value);
            clonedNode.next = currentnode.next;
            currentnode.next = clonedNode;
            currentnode = clonedNode.next;
        }

        //link the random pointers of cloned nodes
        currentnode = head;
        while (currentnode ! = null) {
            currentnode.next.random = currentnode.random != null ? currentnode.random.next : null;
            currentnode = currentnode.next.next;
        }

        //detach the A' - B' - C' from A - A' - B - B' - C - C'
        LinkedList originalHead = head;
        LinkedList clonedHead = head.next;
        LinkedList result = head.next;

        while (originalHead != null) {
            originalHead.next = originalHead.next.next;
            clonedHead.next = clonedHead.next != null ? clonedHead.next.next : null;
            originalHead = originalHead.next;
            clonedHead = clonedHead.next;
        }

        return result;
    }
}