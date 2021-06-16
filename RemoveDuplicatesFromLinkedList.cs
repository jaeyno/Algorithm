using System.Collections.Generic;
using System;

//Time Complexity O(n)
//Space Complexity O(1)

public class Program {
	public class LinkedList {
		public int value;
		public LinkedList next;

		public LinkedList(int value) {
			this.value = value;
			this.next = null;
		}
	}

	public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList) {
		LinkedList currentNode = linkedList;
		
		while (currentNode != null) {
			LinkedList nextDistinctNode = currentNode.next;
			while (nextDistinctNode != null && nextDistinctNode.value == currentNode.value) {
				nextDistinctNode = nextDistinctNode.next;
			}
			
			currentNode.next = nextDistinctNode;
			currentNode = nextDistinctNode;
		}
		
		return linkedList;
	}
}