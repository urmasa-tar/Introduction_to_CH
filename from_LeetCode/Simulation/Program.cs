using static System.Console;
// using BaseBallSimulation;

namespace Simulation;

class MyClass
{

    public static void Main(string[] args)
    {
        BaseBall testObj =  new BaseBall();

        if (args.Length == 0)
        {
            int test = testObj.CalPoints(args);
        }
        else
        {
            // Common testes
            String[] oper = ["5", "2", "D", "C", "+"];
            Console.WriteLine(testObj.CalPoints(oper));
        }
    }
}