public class Solution {
    //Time Complexity: O(n*klog(k)) | Space Complexity: O(n)
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 0 || strs == null) {
            return new List<List<string>>();
        }

        List<List<string>> result = new List<List<string>>();
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            string sortedStr = new string(str.OrderBy(x => x).ToArray());

            if (!dict.ContainsKey(sortedStr)) {
                dict.Add(sortedStr, new List<string>());
            }

            dict[sortedStr].Add(str);
        }

        foreach(var item in dict.Values) {
            result.Add(item);
        }

        return result;
    }
}