public class Solution {
    public int PivotIndex(int[] nums) {
        int totalSum = 0;
        int leftSum = 0;

        for(int i=0 ; i<nums.Length ; i++)
        {
            totalSum += nums[i];
        }

        for(int i=0 ; i<nums.Length ; i++)
        {
            if(leftSum * 2 == totalSum - nums[i])
            return i;

            leftSum += nums[i];
        }

        return -1;
    }
}