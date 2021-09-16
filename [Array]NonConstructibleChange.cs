using System;

public class Program {
    public int NonConstructibleChange(int[] coins) {
        //sort the coins in ascending order
        Array.Sort(coins);

        int currentChange = 0;

        foreach (int coin in coins) {
            if (coin > currentChange + 1) {
                return currentChange + 1;
            }

            currentChange += coin;
        }
        
        return currentChange + 1;
    }
}
//Time complexity is O(nlog(n)) - because of sorting
//Space complexity is O(1)