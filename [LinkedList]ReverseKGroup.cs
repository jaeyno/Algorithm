public class LinkedList {
    public int value;
    public LinkedList next = null;

    public LinkedList(int value) {
        this.value = value;
    }

    public LinkedList ReverseLinkedList(LinkedList head, int k) {
        LinkedList newHead = null;
        LinkedList currentNode = head;
        while (k > 0) {
            //store the reference of currentNode, not to lose the connection
            LinkedList nextNode = currentNode.next;
            //establish a new connection from currentNode to newHead
            currentNode.next = newHead;
            //move newHead to currentNode;
            newHead = currentNode;
            //move currentNode to nextNode;
            currentNode = nextNode;
            k--;
        }
        return newHead;
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList ReverseGroupK(LinkedList head, int k) {
        LinkedList newHead = null;
        LinkedList newTail = null;
        LinkedList currentNode = head;

        while (currentNode != null) {
            int count = 0;
            currentNode = head;
            while (count < k) {
                currentNode = currentNode.next;
                k++;
            }
            if (count == k) {
                ListNode revHead = this.ReverseLinkedList(head, k);
                if (newHead == null) {
                    newHead = revHead;
                }

                if (newTail != null) {
                    newTail.next = revHead;
                }

                newTail = head;
                head = currentNode;
            }
        }

        if (newTail != null) {
            newTail.next = head;
        }

        return newHead == null ? head : newHead;
    }
}