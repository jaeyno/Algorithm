public class Program {
    public class LinkedList {
        public int value;
        public LinkedList next = null;

        public LinkedList(int value) {
            this.value;
        }
    }

    //Time Complexity: O(nlog(n)) | Space Complexity: O(log(n))
    public LinkedList SortLinkedListInASC(LinkedList head) {
        return this.MergeSortLinkedList(head);
    }

    private LinkedList MergeSortLinkedList(LinkedList head) {
        if (head == null || head.next == null) {
            return head;
        }

        ListNode mid = this.GetMiddleNode(head);
        ListNode left = this.MergeSortLinkedList(head);
        ListNode right = this.MergeSortLinkedList(mid);

        return this.MergeTwoLinkedLists(left, right);
    }

    private LinkedList MergeTwoLinkedLists(LinkedList head1, LinkedList head2) {
        LinkedList currentNode1 = head1;
        LinkedList currentNode2 = head2;
        LinkedList newHead = new LinkedList(-1);
        LinkedList dummyNode = newHead;

        while (currentNode1 != null && currentNode2 != null) {
            if (currentNode1.value <= currentNode2.value) {
                dummyNode.next = currentNode1;
                currentNode1 = currentNode1.next;
            } else {
                dummyNode.next = currentNode2;
                currentNode2 = currentNode2.next;
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

    private LinkedList GetMiddleNode(LinkedList head) {
        LinkedList midNode = null;
        LinkedList slowNode = head;
        LinkedList fastNode = head;

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

        midNode = slowNode.next;
        slowNode.next = null;

        return midNode;
    }
}