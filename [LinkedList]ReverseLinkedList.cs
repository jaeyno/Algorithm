public class LinkedList {
    int value;
    LinkedList next = null;

    public LinkedList(int value) {
        this.value = value;
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList ReverseLinkedList(LinkedList head) {
        LinkedList currentNode = head;
        LinkedList prevNode = null;
        while (currentNode != null) {
            LinkedList nextNode = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
        }

        return prevNode;
    }
}