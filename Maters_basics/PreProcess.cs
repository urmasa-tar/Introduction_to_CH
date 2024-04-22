// Pre-procces example
#define PreProcc
// it's posible to check statements with this defs
// Example here and in program function
#define Example

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Maters_basics
{
    // Key-wotd iternal - ?
    public class PreProcess
    {
        public PreProcess() { }

        public byte Statement_with_preprocc()
        {
            byte status = 1;
#if (Example && !Anty)
            Console.WriteLine("Statement is truble");
#else
            Console.WriteLine("Statement incorrect");
#endif
            return status;
        }

        // redgion/endregion preprocc
        public void region_preprocc()
        {
            #region

            #endregion
        }
    }
}
