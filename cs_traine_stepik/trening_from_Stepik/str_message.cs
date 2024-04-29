using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message
{
    public class str_message
    {
        public void concat()
        {
            string[] inputMessages = ReadInput();
            string message1, message2;
            message1 = inputMessages[0];
            message2 = inputMessages[1];
            string result = message1 + " " + message2;

            Console.WriteLine(result);
        }

        public string[] ReadInput()
        {
            string inputLine = Console.ReadLine();

            return inputLine.Split(" | ");
        }
    }

    public class str_int_concat()
    {
        public void concat()
        {
            string[] inputValues = ReadInput();
            string message = inputValues[0];
            int score = int.Parse(inputValues[1]);
            score = score * 2;
            string result = message + " " + score.ToString();

            Console.WriteLine(result);
        }

        public string[] ReadInput()
        {
            string inputLine = Console.ReadLine();
            return inputLine.Split(" | ");
        }
    }
    public class concat_multiple()
    {
        public void multiple_read()
        {
            string message;
            int score, bonus;

            string[] inputValues = ReadInput();
            message = inputValues[0];
            score = int.Parse(inputValues[1]);
            bonus = int.Parse(inputValues[2]);

            string result = "";

            Console.WriteLine(result);
        }

        public string[] ReadInput()
        {
            string inputLine = Console.ReadLine();
            return inputLine.Split(" | ");
        }
    }
}