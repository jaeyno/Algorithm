public class Program {
    public class LinkedList {
        public int value;
        public LinkedList next = null;

        public LinkedList(int value) {
            this.value = value;
        }
    }

    //Time Complexity: O(m + n) | Space Complexity: O(m + n)
    public LinkedList AddTwoLinkedLists(LinkedList head1, LinkedList head2) {
        LinkedList dummyNode = new LinkedList(-1);
        LinkedList newHead = dummyNode;
        LinkedList currentNode1 = head1;
        LinkedList currentNode2 = head2;

        int carry = 0;
        while (currentNode1 != null || currentNode2 != null) {
            int x = currentNode1 != null ? currentNode1.value : 0;
            int y = currentNode2 != null ? currentNode2.value : 0;
            int sum = x + y + carry;
            carry = sum / 10;
            newHead.next = new LinkedList(sum % 10);
            newHead = newHead.next;

            if (currentNode1 != null) currentNode1 = currentNode1.next;
            if (currentNode2 != null) currentNode2 = currentNode2.next;
        }

        if (carry > 0) newHead.next = new LinkedList(carry);
 
        return dummyNode.next;
    }
}