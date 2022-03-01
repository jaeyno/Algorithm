public class program {
    public class LinkedList {
        public int value;
        public LinkedList next = null;

        public LinkedList(int value) {
            this.value = value;
        }
    }

    public LinkedList AddTwoLinkedListInReverseOrder(LinkedList head1, LinkedList head2) {
        LinkedList dummyNode = new LinkedList(-1);
        LinkedList newHead = dummyNode;
        LinkedList currentNode1 = head1;
        LinkedList currentNode2 = head2;

        int carrier = 0;

        while (currentNode1 != null || currentNode2 != null) {
            int x = currentNode1 != null ? currentNode1.value : 0;
            int y = currentNode2 != null ? currentNode2.value : 0;
            int sum = x + y + carrier;
            carrier = sum / 10;
            newHead.next = new LinkedList(sum % 10);

            //arrange the pointers
            newHead = newHead.next;
            if (currentNode1 != null) currentNode1 = currentNode1.next;
            if (currentNode2 != null) currentNode2 = currentNode2.next;
        }

        if (carrier > 0) {
            newHead.next = new LinkedList(carrier);
        }

        return dummyNode.next;
    }

    public LinkedList AddTwoLinkedListsInDirectOrder(LinkedList head1, LinkedList head2) {
        LinkedList dummyNode = new LinkedList(-1);
        LinkedList newHead = dummyNode;
        LinkedList currentNode1 = this.ReverseLinkedList(head1);
        LinkedList currentNode2 = this.ReverseLinkedList(head2);

        int carrier = 0;
        while (currentNode1 != null || currentNode2 != null) {
            int x = currentNode1 != null ? currentNode1.value : 0;
            int y = currentNode2 != null ? currentNode2.value : 0;
            int sum = x + y + carrier;
            carrier = sum / 10;
            newHead.next = new LinkedList(sum % 10);

            //rearrange the pointers
            if (currentNode1 != null) currentNode1 = currentNode1.next;
            if (currentNode2 != null) currentNode2 = currentNode2.next;
            newHead = newHead.next;
        }

        if (carrier > 0) {
            newHead.next = new LinkedList(carrier);
        }

        return this.ReverseLinkedList(dummyNode.next);
    }

    public LinkedList ReverseLinkedList(LinkedList head) {
        LinkedList prevNode = null;
        LinkedList currentNode = head;

        while (currentNode != null) {
            LinkedList nextNode = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
        }

        return prevNode;
    }
}