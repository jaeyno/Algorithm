public class LinkedList {
    public int value;
    public LinkedList next = null;
    public LinkedList(int value) {
        this.value = value;
    }

    public LinkedList SortLinkedList(ListNode head) {
        return this.MergeSort(head);
    }

    private LinkedList MergeSort(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        LinkedList newHead = null;
        LinkedList slowNode = head;
        LinkedList fastNode = head.next;

        while (fastNode != null) {
            if (fastNode.next != null) {
                fastNode = fastNode.next.next;
            } else {
                fastNode = null;
            }

            if (fastNode != null) {
                slowNode = slowNode.next;
            }
        }

        newHead = slowNode.next;
        slowNode.next = null;

        ListNode firstHalf = MergeSort(slowNode);
        ListNode secondHalf = MergeSort(newHead);

        return this.MergeLinkedLists(firstHalf, secondHalf);
    }

    private LinkedList MergeLinkedLists(LinkedList head1, LinkedList head2) {
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