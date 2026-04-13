public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        var interm = new List<int>(nums);
        var output= new List<int>();
        foreach(var num in interm.ToList()){
            interm.Remove(num);
            var temp = 1;
            foreach(var num1 in interm){
                temp *= num1;
            }
            output.Add(temp);
            interm.Add(num);
        }
        return output.ToArray();
    }
}
