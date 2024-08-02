using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regularState
{
    public class RegexStatemants
    {
        RegexStatemants() { }

        protected bool isEmail(string s)
        {
            Regex regex = new Regex(@"(?= *@)");
        }
    }
}
