using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpei_curse
{
    class Introduction
    {
        public void Console_Out()
        {
            int ln = (Read_Inp())[0];
            int[] array = Read_Inp();

            Console.WriteLine(Max_int_arr(ln, array));

        }

        public int[] Read_Inp()
        {

            string inputLine = Console.ReadLine();
            string[] values = inputLine.Split(' ');
            int[] int_cp_values = new int[values.Length];
            int i = 0;
            foreach (string val in values)
            {
                int_cp_values[i] = int.Parse(val);
                i += 1;
            }

            return int_cp_values;
        }

        public int Max_int_arr(int n, int[] array)
        {
            int res = array[0];

            foreach (int var in array)
            {
                if((var > res) && (var % 4 == 0))
                {
                    res = var;
                }
            }

            return res;
        }
    }

    class Factorial
    {
        public void Console_out()
        {

        }

        long fact_rec(int corr_n)
        {
            long res = 0;

            if(corr_n == 1)
            {
                res = 1;
            }
            else
            {
                res = fact_rec(corr_n - 1) * corr_n;
            }

            return res;
        }

        public int Read_Inp()
        {
            int res = int.Parse(Console.ReadLine());

            return res;
        }
    }
}
