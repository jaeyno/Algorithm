public class LinkedList {
    public int value;
    public LinkedList next = null;

    public LinkedList(int value) {
        this.value = value;
    }

    //Time Complexity: O(kN) - k is the number of linked lists | Space Complexity: O(1)
    public LinkedList MergeKSortedLinkedLists(LinkedList[] lists) {
        LinkedList head = null;
        for (int i = 0; i <= lists.Length; i++) {
            head = this.MergeLinkedLists(head, lists[i]);
        }

        return head;
    }

    public LinkedList MergeLinkedLists(LinkedList head1, LinkedList head2) {
        LinkedList dummyNode = new LinkedList(-1);
        LinkedList newHead = dummyNode;
        LinkedList currentNode1 = head1;
        LinkedList currentNode2 = head2;

        while (currentNode1 != null && currentNode2 != null) {
            if (currentNode1.value <= currentNode2.value) {
                newHead.next = currentNode1;
                currentNode1 = currentNode1.next;
            } else {
                newHead.next = currentNode2;
                currentNode2 = currentNode2.next;
            }

            newHead = newHead.next;
        }

        if (currentNode1 != null) {
            newHead.next = currentNode1;
        }

        if (currentNode2 != null) {
            newHead.next = currentNode2;
        }

        return dummyNode.next;
    }
}