public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int diff = arr[1]-arr[0];
        for(int i=2;i<arr.Length;i++)
            if(diff != arr[i]-arr[i-1]) return false;
        return true;
    }
}