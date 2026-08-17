public class Solution {

    public string Encode(IList<string> strs) {
        var encodes = new List<string>();
        foreach (string s in strs) {
            encodes.Add(s.Length + ":" + s);
        }
        return string.Join("", encodes);
    }

    public List<string> Decode(string s) {
        var res = new List<string>();
        var i = 0;
        while (i < s.Length) {
            int colon = s.IndexOf(':', i);
            int len = int.Parse(s.Substring(i, colon - i));
            res.Add(s.Substring(colon + 1, len));
            i = colon + 1 + len;
        }
        return res;
   }
}
