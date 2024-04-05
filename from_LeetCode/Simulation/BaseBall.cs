namespace Simulation;
using System.Runtime.CompilerServices;
using static System.Console;



class BaseBall
{

    public int CalPoints(string[] operations)
    {
        int ln = operations.Length;
        int[] sum = [0, 0 ,0];
        for (int i = 0; i < ln; i++)
        {
            int swap;
            switch (operations[i])
            {
                case "C":
                    
                    break;
                
                case "D":
                    
                    break;
                
                case "+":
                    
                    break;
                
                default:
                    int local = Str_To_Int(operations[i]);
                    
                    break;
            }
        }
        
        return sum[0];
    }

    public static int Str_To_Int(String numS)
    {
        int res = 0;

        for (int i = 0; i < numS.Length; i++)
        {
            res = res * 10 + (int)(numS[i] - '0');
        }
        
        return res; 
    }

}