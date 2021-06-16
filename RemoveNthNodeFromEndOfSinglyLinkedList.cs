using System;

public class Program {
	//O(n) time | O(1) space
	public static void RemoveKthNodeFromEnd(LinkedList head, int k) {
		int counter = 1;
		LinkedList firstPointer = head;
		LinkedList secondPointer = head;
		while (counter <= k) {
			secondPointer = secondPointer.Next;
			counter++;
		}
		if (secondPointer == null) {
			head.Value = head.Next.Value;
			head.Next = head.Next.Next;
			return;
		}
		
		while (secondPointer.Next != null) {
			secondPointer = secondPointer.Next;
			firstPointer = firstPointer.Next;
		}
		
		firstPointer.Next = firstPointer.Next.Next;
	}

	public class LinkedList {
		public int Value;
		public LinkedList Next = null;

		public LinkedList(int value) {
			this.Value = value;
		}
	}
}
