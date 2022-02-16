public class Program {
    public class LinkedList {
        public int value;
        public LinkedList next;

        public LinkedList(int value) {
            this.value = value;
            this.next = null;
        }
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList RemoveDuplicates(LinkedList linkedList) {
        LinkedList currentNode = linkedList;
        while (currentNode != null) {
            LinkedList nextNode = currentNode.next;
            while (nextNode != null && currentNode.value == nextNode.value) {
                nextNode = nextNode.next;
            }
            currentNode.next = nextNode;
            currentNode = nextNode;
        }

        return linkedList;
    }
}
