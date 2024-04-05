using static System.Console;
using static Simulation.BaseBall;
using static Simulation.Robot_Return;
namespace Simulation;

class MyClass
{

    public static void Main(string[] args)
    {
        BaseBall testObj =  new BaseBall();

        if (args.Length > 0)
        {
            int test = testObj.CalPoints(args);
            Console.WriteLine(test);
        }
        else
        {   
            // Out_Check();
            // Common testes
            String[] oper = ["5", "2", "C", "D", "+"];
            Console.WriteLine(testObj.CalPoints(oper));
        }
    }

    public static void Out_Check()
    {
        var words = new[] {"люблю", "я", "смотреть", "сложный", "небо", "на", "очень"};
        Console.WriteLine(string.Join(" ", words));
    }
}