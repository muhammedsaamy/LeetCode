public class Solution {
    public bool IsSubsequence(string s, string t) {
           int pointer = 0;
            foreach (var item in s)
            {
                int exist = t.IndexOf(item, pointer == 0 ? 0 : pointer + 1);

                if (exist == -1)
                    return false;

                if(pointer == 0) {     
                    pointer = exist;
                } else if(exist < pointer)
                {
                    return false;
                }
                else
                {
                    pointer = exist;
                }
            }
            return true;
    }
}