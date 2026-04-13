public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       List<List<string>> groupedAnagrams = new List<List<string>>();
       bool[] visited = new bool[strs.Length];

        for (int i = 0; i < strs.Length; i++) {
            if (visited[i]) continue;

            List<string> group = new List<string> { strs[i] };
            visited[i] = true;

            for (int j = i + 1; j < strs.Length; j++) {
                if (!visited[j] && areAnagrams(strs[i], strs[j])) {
                    group.Add(strs[j]);
                    visited[j] = true;
                }
            }

            groupedAnagrams.Add(group);
        }

        return groupedAnagrams;
        
    }
    private bool areAnagrams(string a, string b) {
        if (a.Length != b.Length) return false;

        char[] arrayA = a.ToCharArray();
        char[] arrayB = b.ToCharArray();
        Array.Sort(arrayA);
        Array.Sort(arrayB);

        return arrayA.SequenceEqual(arrayB);
    }


}
