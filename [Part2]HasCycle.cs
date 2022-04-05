public class Solution {
    //Time Complexity: O(n) | Space Complexity: O(n)
    public bool HasCycleWithHashSet(LinkedList head) {
        HashSet<LinkedList> existingNodes = new HashSet<LinkedList>();
        
        while (head != null) {
            if (existingNodes.Contains(head)) {
                return true;
            }

            existingNodes.Add(head);
            head = head.next;
        }

        return false;
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public bool HasCycleInPlace(LinkedList head) {
        LinkedList slow = head;
        LinkedList fast = head.next;

        if (head == null) return false;

        while (slow != fast) {
            if (fast == null || fast.next == null) {
                return false;
            }

            slow = slow.next;
            fast = fast.next.next;
        }

        return true;
    }
}