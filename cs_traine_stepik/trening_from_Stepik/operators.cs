using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators_classes
{
    public class operators
    {
        public void oper_func()
        {
            int x, y;

            int[] inputValues = ReadInput();
            x = inputValues[0];
            y = inputValues[1];

            int result = 0;

            Console.WriteLine(result);
        }

        public static int[] ReadInput()
        {
            string inputLine = Console.ReadLine();
            string[] values = inputLine.Split(' ');
            int[] result = new int[2];
            result[0] = int.Parse(values[0]);
            result[1] = int.Parse(values[1]);

            return result;
        }

    }


}
