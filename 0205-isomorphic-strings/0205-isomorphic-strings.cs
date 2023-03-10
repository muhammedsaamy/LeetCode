public class Solution {
    public bool IsIsomorphic(string s, string t) {
        for (var i = 0; i < s.Length; i++)
        {
            if (s.IndexOf(s[i]) != t.IndexOf(t[i]))
                return false;
        }
      return true;
    }
}