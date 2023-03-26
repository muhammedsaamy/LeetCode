public class Solution {
    public int CountOdds(int low, int high) {
	return (high - low) / 2 + (high % 2 | low % 2);

    }
}