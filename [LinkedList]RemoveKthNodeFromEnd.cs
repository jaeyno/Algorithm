public class LinkedList {
    public int value;
    public LinkedList next;

    public LinkedList(int value) {
        this.value = value;
        this.next = null;
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList RemoveKthNodeFromEnd(LinkedList head, int k) {
        LinkedList first = head;
        LinkedList second = head;
        
        int count = 1;
        while (count <= k) {
            second = second.next;
            count++;
        }

        //if k is greater than the length of given linked list, remove the head
        if (second == null) {
            head.value = head.next.value;
            head.next = head.next.next;
            return;
        }

        while (second.next != null) {
            first = first.next;
            second = second.next;
        }

        first.next = first.next.next;
    }
}