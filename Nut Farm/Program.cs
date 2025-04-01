using System.Linq;

public class Dinglemouse
{
    public static int[] ShakeTree(string[] tree)
    {
        int[] result = new int[tree[0].Length];
    
        for(int i = 0;i < tree.Length; i++)
        {
            for(int j = 0; j < tree[i].Length;j++)
            {
                if(tree[i][j] == 'o')
                    result[j]=1;
        
                if(tree[i][j] == '_')
                    result[j]=0;
        
                if(tree[i][j] == '/')
                {
                    result[j-1]+=result[j];
                    result[j] = 0;
                }
        
                if(tree[i][j] == '\\')
                {
                    result[j+1]+=result[j];
                    result[j] = 0;
                }
            }
        }
        return result;
    }
}