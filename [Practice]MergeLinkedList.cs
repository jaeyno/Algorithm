public class Program {
    public class LinkedList {
        public int value;
        public LinkedList next = null;

        public LinkedList(int value) {
            this.value = value;
        }
    }

    //Time Complexity: O(kN) - K is the number of lists | Space Complexity: O(1)
    public LinkedList MergeKGroup(LinkedList[] lists) {
        LinkedList newHead = null;
        for (int i = 0; i < lists.Length; i++) {
            newHead = this.MergeTwoLinkedLists(newHead, lists[i]);
        }
        return newHead;
    }

    public LinkedList MergeTwoLinkedLists(LinkedList head1, LinkedList head2) {
        LinkedList dummyNode = new LinkedList(-1);
        LinkedList newTail = dummyNode;
        LinkedList currentNode1 = head1;
        LinkedList currentNode2 = head2;

        while (currentNode1 != null && currentNode2 != null) {
            if (currentNode1.value <= currentNode2.value) {
                newTail.next = currentNode1;
                currentNode1 = currentNode1.next;
            } else {
                newTail.next = currentNode2;
                currentNode2  = currentNode2.next;
            }

            newTail = newTail.next;
        }

        if (currentNode1 != null) {
            newTail.next = currentNode1;
        }

        if (currentNode2 != null) {
            newTail.next = currentNode2;
        }

        return dummyNode.next;
    }
}