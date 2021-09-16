using System.Collections.Generic;

public class Program {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
        //Create a new hash table
        HashSet<int> numbers = new HashSet<int>();

        //targetSum = x + y ==> y = targetSum - x
        foreach (int x in array) {
            int y = targetSum - x;
            if (numbers.Contains(y)) {
                return new int[] {x, y};
            } else {
                numbers.Add(x);
            }
        }

        return new int[] {};
	}
}

//Since we used hash table, time complexity is O(n) & space complexity is O(n)