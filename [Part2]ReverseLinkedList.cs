public class Solution {
    public class LinkedList {
        public int value;
        public LinkedList next;

        public LinkedList(int value, LinkedList next) {
            this.value = value;
            this.next = next;
        }
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList ReverseLinkedList(LinkedList head) {
        //initialize variable
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