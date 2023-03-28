public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
        int smallestMd=int.MaxValue;
        int smallestIndex=-1;
        
        for(int i=0;i<points.Length;i++)
        {
            
            if(points[i][0]==x || points[i][1]==y)
            {
                int md=Math.Abs(x-points[i][0])+Math.Abs(y-points[i][1]);
                
                if(md<smallestMd)
                {
                    smallestMd=md;
                    smallestIndex=i;
                }
            }
        }
        return smallestIndex;
    }
}