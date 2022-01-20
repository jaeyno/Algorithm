using System;

public class Program {
    public static int GetNthFib(int n) {
        if (n == 1) {
            return 0;
        } else if (n == 2) {
            return 1;
        } else {
            return GetNthFib(n - 1) + GetNthFib(n - 2);
        }
    }
    //Time Complexity: O(2^n) recursion | Space Complexity: O(n) due to call stack

    public static int GetNthFibWithDictionary(int n) {
        Dictionary<int, int> memory = new Dictionary<int, int>();
        memory.Add(1, 0);
        memory.Add(2, 1);
        
        return GetNthFibWithDictionary(n, memory);
    }

    public static int GetNthFibWithDictionary(int n, Dictionary memory) {
        if (memory.ContainsKey(n)) {
            return memory[n];
        } else {
            memory.Add(n, GetNthFibWithDictionary(n - 1, memory) + GetNthFibWithDictionary(n - 2, memory));
            return memory[n];
        }
    }
    // Time Complexity: O(n) | Space Complexity: O(n) due to call stack
}