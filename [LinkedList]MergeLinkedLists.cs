public class LinkedList {
    public int value;
    public LinkedList next = null;
    public LinkedList(int value) {
        this.value = value;
    }

    //Time Complexity: O(n + m) where n - headOne nodes, m - headTwo nodes | Space Complexity: O(1)
    public LinkedList MergeLinkedList(LinkedList headOne, LinkedList headTwo) {
        LinkedList first = headOne;
        LinkedList second = headTwo;
        LinkedList prev = null;

        while (first != null && second != null) {
            if (first.value < second.value) {
                prev = first;
                first.next = first;
            } else {
                if (prev != null) {
                    prev.next = second;
                }
                prev = second;
                second = second.next;
                prev.next = first;
            }
        }
        if (first == null) {
            prev.next = second;
        }

        return headOne.value < headTwo.value ? headOne : headTwo;
    }
}