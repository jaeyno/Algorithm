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
        LinkedList newHead = new LinkedList(-1);
        LinkedList dummyNode = newHead;
        LinkedList currentNode1 = head1;
        LinkedList currentNode2 = head2;

        while (currentNode1 != null && currentNode2 != null) {
            if (currentNode1.value <= currentNode2.value) {
                dummyNode.next = currentNode1;
                currentNode1 = currentNode1.next;
            } else {
                dummyNode.next = currentNode2;
                currentNode2  = currentNode2.next;
            }

            dummyNode = dummyNode.next;
        }

        if (currentNode1 != null) {
            dummyNode.next = currentNode1;
        }

        if (currentNode2 != null) {
            dummyNode.next = currentNode2;
        }

        return newHead.next;
    }
}