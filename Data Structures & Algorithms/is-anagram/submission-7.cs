public class Solution {
    public bool IsAnagram(string s, string t) {
        var sortedFirstList = s.ToCharArray();
        Array.Sort(sortedFirstList);
        var sortedSecondList = t.ToCharArray();
        Array.Sort(sortedSecondList);
        Console.WriteLine("sortedFirstList",sortedFirstList);
        Console.WriteLine("sortedSecondList",sortedSecondList);
        return sortedFirstList.SequenceEqual(sortedSecondList);

    }
}
