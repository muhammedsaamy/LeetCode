public class Solution {
    public int[] RunningSum(int[] nums) {
         int[] answer = new int[nums.Length];
        answer[nums.Length - 1] = nums.Sum();
        for (int i = nums.Length - 2; i >= 0; i--) {           
            answer[i] = answer[i + 1] - nums[i + 1];
        }
        return answer;
    }
}