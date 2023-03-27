public class Solution {
    public int SubtractProductAndSum(int n) {
        int SubtractProAndSum = 0, sum=0, mul=1;
        string dd = n.ToString();

        for (int i = 0; i < dd.Length; i++)
        {
             sum =sum + Convert.ToInt32(dd[i].ToString());
             mul = mul * Convert.ToInt32(dd[i].ToString());
            
        }
        SubtractProAndSum = mul - sum;
        return SubtractProAndSum;
    }
    }