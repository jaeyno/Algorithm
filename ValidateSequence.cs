using System;
using System.Collections.Generic;

public class Program {
    public static bool isValidateSequence(List<int> mainArray, List<int> seqArray) {
        int seqIndex = 0;

        foreach (int number in mainArray) {
            // break if it traversed until the end of the seqArray
            if (seqIndex == seqArray.Count) {
                break;
            }
            if (number == seqArray[seqIndex]) {
                seqArray++;
            }
        }

        return seqIndex == seqArray.Count;
    }
}

//Since the worst scenario case is it travers untill the end of the main array
//Time complexity is O(n) -- n is the length of main array
//Space complexity is O(1)