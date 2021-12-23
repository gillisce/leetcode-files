/*ou are asked to cut off all the trees in a forest for a golf event. The forest is represented as an m x n matrix. In this matrix:

0 means the cell cannot be walked through.
1 represents an empty cell that can be walked through.
A number greater than 1 represents a tree in a cell that can be walked through, and this number is the tree's height.
In one step, you can walk in any of the four directions: north, east, south, and west. If you are standing in a cell with a tree, you can choose whether to cut it off.

You must cut off the trees in order from shortest to tallest. When you cut off a tree, the value at its cell becomes 1 (an empty cell).

Starting from the point (0, 0), return the minimum steps you need to walk to cut off all the trees. If you cannot cut off all the trees, return -1.

You are guaranteed that no two trees have the same height, and there is at least one tree needs to be cut off.


Input: forest = [[1,2,3],[0,0,4],[7,6,5]]
Output: 6
Explanation: Following the path above allows you to cut off the trees from shortest to tallest in 6 steps

Input: forest = [[1,2,3],[0,0,0],[7,6,5]]
Output: -1
Explanation: The trees in the bottom row cannot be accessed as the middle row is blocked.
*/

namespace leetcode.AmazonTestPrep
{
    public class ForestSolution {
    
    private readonly IList<int[]> _directions = new List<int[]>()
    {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },            
        new int[] { 0, -1 }
    };
    
    public int CutOffTree(IList<IList<int>> forest) {
        
        if (forest == null)
        {
            throw new ArgumentNullException("Parameter cannot be null", nameof(forest));
        }
        
        // Note that here we will store <height:coordinates>
        var treeMap = new Dictionary<int, int[]>();
        var row = 0;
        var col = 0;
        foreach(var forestSpot in forest){
            foreach(var treeHeight in forestSpot){
                if(treeHeight > 1){
                    treeMap.Add(treeHeight, new int[]{row, col});
                }
                col++;
            }
            row++;
        }
        
        var result = 0;
        var startRow = 0;
        var startCol = 0;
        var sortedTreeMap = treeMap.OrderBy(kvp => kvp.Key);
        
        foreach (var treeMapObject in sortedTreeMap)
        {
            var endRow = treeMapObject.Value[0];
            var endCol = treeMapObject.Value[1];
            
            var steps = GetPath(forest, startRow, startCol, endRow, endCol);
            if (steps == -1)
            {
                return -1;
            }
            
            result += steps;
            startRow = endRow;
            startCol = endCol;
        }
        return result;
    }
    
    private int GetPath(IList<IList<int>> forest, int startRow, int startCol, int endRow, int endCol){
        if (startRow == endRow && startCol == endCol)
        {
            return 0;
        }
        
        var queue = new Queue<int[]>();
        queue.Enqueue(new int[] { startRow, startCol });
        
        var visited = new int[forest.Count, forest[0].Count];
        visited[startRow, startCol] = 1;
        
        var level = 0;
        
        while (queue.Count > 0)
        {
            level++;
            var size = queue.Count;
            while (size > 0)
            {
                var oldNode = queue.Dequeue();
                var oldRow = oldNode[0];
                var oldCol = oldNode[1];
                                
                foreach (var d in _directions)
                {
                    var newRow = oldRow + d[0];
                    var newCol = oldCol + d[1];
                    
                    if (newRow >= 0 && newRow < forest.Count && newCol >= 0 && newCol < forest[0].Count && forest[newRow][newCol] != 0 && visited[newRow, newCol] == 0)
                    { 
                        if (newRow == endRow && newCol == endCol)
                        {
                            return level;
                        }                        
                        
                        visited[newRow, newCol] = 1;                        
                        queue.Enqueue(new int[] { newRow, newCol });
                    }
                }
                
                size--;
            }
        }
        
        return -1;


    }
        
    }
}