public class Progarm {
    public int[] TwoSumToReturnIndex(int[] array, int target) {
        Dictionary<int, int> map = new Dictionary<int, int> ();
        for (int i = 0; i < array.Length; i++) {
            int potentialMatch = target - array[i];
            if (map.ContainsKey(potentialMatch)) {
                return new int[] {map[potentialMatch], i};
            } else {
                //Since dictionary doesn't allow duplicate number
                if (!(map.ContainsKey(array[i]))) {
                    map.Add(array[i], i);
                }
            }
        }

        return new int[0];
    }

    public int[] TwoSumToReturnValue(int[] array, int target) {
        HashSet<int> set = new HashSet<int> ();
        foreach (int number in array) {
            int potentialMatch = target - number;
            if (set.Contains(potentialMatch)) {
                return new int[] {potentialMatch, number};
            } else {
                set.Add(number);
            }
        }

        return new int[0];
    }
}