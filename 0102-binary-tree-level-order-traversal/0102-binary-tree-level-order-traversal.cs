/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) 
{
	var result = new List<IList<int>>();
        
    var queue = new Queue<(TreeNode Node, int Level)>();
    queue.Enqueue((root, 0));
        
	while(queue.Count > 0)
    {
		var item = queue.Dequeue();
        if (item.Node != null)
        {
			if (result.Count < item.Level + 1)
            {
				result.Add(new List<int>());
			}
                
			result[item.Level].Add(item.Node.val);
                
            queue.Enqueue((item.Node.left, item.Level + 1));
            queue.Enqueue((item.Node.right, item.Level + 1));
        }
	}
        
    return result;
}
}