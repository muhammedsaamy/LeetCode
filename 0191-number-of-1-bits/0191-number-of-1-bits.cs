public class Solution {
    public int HammingWeight(uint n) {
        uint c = 0;

	while(n > 0)
	{
		c += n & 1; // or: c += n % 2;
		n >>= 1;    // or: n /= 2;
	}

	return (int) c;
    }
}