public class Solution {
    public double Average(int[] salary) {
        return (double)(salary.Sum()-salary.Max()-salary.Min())/(salary.Count()-2);
    }
}