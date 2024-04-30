using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trening_from_Stepik
{
    class ruler
    {
        public void to_star()
        {
            string star = "";

            string inp_str = ReadInput();

            int ln = inp_str.Length;

            for (int i = 0; i < ln; i++)
            {
                star += "*";
            }

            Console.WriteLine(star.ToString());
        }

        public string ReadInput()
        {
            string res = "";

            if (Console.ReadLine() is string input)
            {
                res = input;
            }

            return res;
        }
    }
}
