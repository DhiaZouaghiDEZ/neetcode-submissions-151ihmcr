public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count()==1 && strs[0] == ""){
            return "";
        }
        else if (strs.Count()==0) {      
            return "emptystring";
        }
        else{
            return String.Join("~~",strs);
        }
        
        
    }

    public List<string> Decode(string s) {
        if (s == ""){
            var strs2 = new List<string>{s};
            return strs2;
        }
        else if (s=="emptystring"){
            return new List<string>();
        }
        else{
            return s.Split("~~").ToList();
        }
   }
}
