public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] topKFrequent = new int[k];
        Dictionary<int,int> frequentElementCount = new Dictionary<int,int>();
        foreach (int num in nums)
        {
            if (frequentElementCount.ContainsKey(num))
                frequentElementCount[num]++;
            else
                frequentElementCount.Add(num, 1);
        }
        var sortedCountedDesc = frequentElementCount.OrderByDescending(kvp => kvp.Value).ToList();
        for (int i = 0; i < k; i++)
            topKFrequent[i] = sortedCountedDesc[i].Key;
        return topKFrequent;
    }
}
