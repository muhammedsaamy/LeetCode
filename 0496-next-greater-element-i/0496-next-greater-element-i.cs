public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] ans = new int[nums1.Length];

        for (int i = 0; i < nums1.Length; i++)
        {
            bool found = false;
            bool signed = false;
            for (int j = 0; j < nums2.Length; j++)
            {
                if (found && nums2[j] > nums1[i])
                {
                    ans[i] = nums2[j];
                    signed = true;
                    break;
                }
                if (nums2[j] == nums1[i])
                {
                    found = true;
                }
            }
            if (signed == false) ans[i] = -1;
        }


        return ans;
    }
}