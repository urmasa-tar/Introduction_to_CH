namespace Simulation;

public class Robot_Return
{
    
    Dictionary<char, int> dir = new Dictionary<char, int>();
    
    public bool JudgeCircle(string moves)
    {
        bool res = true;
        int[] arr = {0, 0};
        char[] path = { 'U', 'D', 'L', 'R' };

        for (int i = 0; i < path.Length; i++)
        {
            dir[path[i]] = -2 * (i % 2) + 1;
        }
        
        
        // foreach - one of the best iterations way
        foreach (char side in moves)
        {
            if ((side == 'U') || (side == 'D'))
            {
                arr[0] += dir[side];
                
            }
            else
            {
                arr[1] += dir[side];
            }
        }

        if ((arr[0] != 0) || (arr[1] != 0)) res = false;
        
        return res;
    }
    
    
}
