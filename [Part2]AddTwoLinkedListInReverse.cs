public class Solution {
    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList AddTwoNumbersInReverse(LinkedList head1, LinkedList head2) {
        //Initialize variables
        LinkedList dummyNode = new LinkedList(-1);
        LinkedList newHead = dummyNode;
        int carrier = 0;

        //Reverse the linked lists
        LinkedList reversedHead1 = this.ReverseLinkedList(head1);
        LinkedList reversedHead2 = this.ReverseLinkedList(head2);

        while (reversedHead1 != null || reversedHead2 != null) {
            int number1 = reversedHead1 != null ? reversedHead1.value : 0;
            int number2 = reversedHead2 != null ? reversedHead2.value : 0;
            int sum = number1 + number2 + carrier;
            carrier = sum / 10;
            newHead.next = new LinkedList(sum % 10);
            newHead = newHead.next;

            if (reversedHead1 != null) reversedHead1 = reversedHead1.next;
            if (reversedHead2 != null) reversedHead2 = reversedHead2.next;
        }

        if (carrier > 0) {
            newHead.next = new LinkedList(carrier);
        }

        return this.ReverseLinkedList(dummyNode.next);
    }

    private ReverseLinkedList(LinkedList head) {
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