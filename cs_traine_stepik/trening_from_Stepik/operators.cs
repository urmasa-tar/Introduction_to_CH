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
            string res = "";
            int result = 0;
            int[] inputValues = ReadInput();

#if sum
            x = inputValues[0];
            y = inputValues[1];
#else
            if (inputValues[0] % 2 == 0)
            {
                res = "нечет";
            }
            else
            {
                res = "чет";
            }
#endif

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
