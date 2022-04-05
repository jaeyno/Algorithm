public class Solution {
    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList AddTwoNumbers(LinkedList head1, LinkedList head2) {
        //initialize nodes
        LinkedList dummyNode = new LinkedList(-1);
        LinkedList newHead = dummyNode;
        int carrier = 0;

        while (head1 != null || head2 != null) {
            int number1 = head1 != null ? head1.value : 0;
            int number2 = head2 != null ? head2.value : 0;
            int sum = number1 + number2;
            carrier = sum / 10;
            newHead.next = new LinkedList(sum % 10);
            newHead = newHead.next;

            if (head1 != null) {
                head1 = head1.next;
            }

            if (head2 != null) {
                head2 = head2.next;
            }
        }

        if (carrier > 0) {
            newHead.next = new LinkedList(carrier);
        }

        return dummyNode.next;
    }
}