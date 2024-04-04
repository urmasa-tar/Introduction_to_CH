using System.Runtime.CompilerServices;
using static System.Console;



class BaseBall
{

    public int CalPoints(string[] operations)
    {
        int ln = operations.Length;
        int sum = 0;
        int prev = 0;
        for (int i = 0; i < ln; i++)
        {
            int swap;
            switch (operations[i])
            {
                case "C":
                    swap = sum;
                    sum = prev;
                    prev = sum;
                    break;
                
                case "D":
                    prev = sum;
                    sum *= 2;
                    break;
                
                case "+":
                    swap = sum;
                    sum = sum + prev;
                    prev = swap;
                    break;
                
                default:
                    int local = Str_To_Int(operations[i]);
                    sum += local;
                    break;
            }
        } 
        
        return sum;
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
