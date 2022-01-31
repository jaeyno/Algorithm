public class MinHeap {
	public List<int> heap = new List<int> ();

	public MinHeap(List<int> array) {
		heap = BuildMinHeap(array);
	}

	//Time Complexity: O(n) | Space Complexity: O(1)
	public List<int> BuildMinHeap(List<int> array) {
		//Building a heap always starts from the most left & bottom parent node
		//Find the most left & bottom paerent node from this equation, floor((i -1) / 2)
		int parentIndex = (array.Count - 1 - 1) / 2;
		for (int currentIndex = parentIndex; currentIndex >= 0; currentIndex--) {
			SiftDown(currentIndex, array.Count - 1, array);
		}
		return array;
	}

	//Time Complexity: O(log(n)) | Space Complexity: O(1)
	public void SiftDown(int currentIndex, int endIndex, List<int> array) {
		//Find the index of the first child node, (2 * i) + 1
		int firstChildIndex = (2 * currentIndex) + 1;
		
		//Iterate until firstChildIndex is out of the range
		while (firstChildIndex <= endIndex) {
			//Find the index of the second child node, (2 * i) + 2
			int secondChildIndex = (2 * currentIndex) + 2 <= endIndex ? (2 * currentIndex) + 2 : -1;
			int indexToSwap;
			if (secondChildIndex != -1 && array[secondChildIndex] < array[firstChildIndex]) {
				indexToSwap = secondChildIndex;
			} else {
				indexToSwap = firstChildIndex;
			}

			if (array[indexToSwap] < array[currentIndex]) {
				Swap(currentIndex, indexToSwap, array);
				currentIndex = indexToSwap;
				firstChildIndex = (2 * currentIndex) + 1;
			} else {
				return;
			}
		}
	}

	//Time Complexity: O(log(n)) | Space Complexity: O(1)
	public void SiftUp(int currentIndex, List<int> array) {
		int parentIndex = (currentIndex - 1) / 2;
		while (currentIndex > 0 && array[currentIndex] < array[parentIndex]) {
			Swap(currentIndex, parentIndex, array);
			currentIndex = parentIndex;
			parentIndex = (currentIndex - 1) / 2;
		}
	}

	//Swap the two index
	public void Swap(int i, int j, List<int> array) {
		int temp = array[j];
		array[j] = array[i];
		array[i] = temp;
	}

	//Peek the minimum value in the heap
	public int Peek() {
		return heap[0];
	}

	public int Remove() {
		Swap(0, heap.Count - 1, heap);
		int valueToRemove = heap[heap.Count - 1];
		heap.RemoveAt(heap.Count - 1);
		SiftDown(0, heap.Count -1, heap);
		return valueToRemove;
	}

	public void Insert(int value) {
		heap.Add(value);
		SiftUp(heap.Count - 1, heap);
	}
}