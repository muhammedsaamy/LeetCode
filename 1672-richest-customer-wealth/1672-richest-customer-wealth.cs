public class Solution {
    public int MaximumWealth(int[][] accounts) {
           int res = 0;
        for(int i =0;i<accounts.Length;i++){
            int temp = 0;
            for(int j = 0;j<accounts[i].Length;j++){
                temp+=accounts[i][j];
            }
            res = Math.Max(res,temp);
        }
        return res;
    }
}