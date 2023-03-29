public class Solution {
    public bool IsHappy(int n) {
        var visited = new HashSet<int>();

        while (n != 1)
        {
            var nextNumber = 0;
            while (n != 0)
            {
                var lastDigit = n % 10;
                nextNumber += lastDigit * lastDigit;
                n /= 10;
            }

            if (visited.Contains(nextNumber))
            {
                return false;
            }

            visited.Add(nextNumber);
            
            n = nextNumber;
        }
        
        return true;
    }
}