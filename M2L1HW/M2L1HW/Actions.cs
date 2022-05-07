using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace M2L1HW
{
    internal class Actions
    {
        public Result FirstMethod()
        {
            DateTime dateTime = DateTime.Now;
            Logger.Log = $"{{{dateTime}}}: {{Info}}: {{Start Method: {MethodBase.GetCurrentMethod().Name}}}";
            Logger.WriteInFile();
            return new Result { Status = true };
        }

        public Result SecondMethod()
        {
            DateTime dateTime = DateTime.Now;
            Logger.Log = $"{{{dateTime}}}: {{Warning}}: {{Skipped logic in Method: {MethodBase.GetCurrentMethod().Name}}}";
            Logger.WriteInFile();
            return new Result { Status = true };
        }

        public Result ThirdMethod()
        {
            return new Result { Status = false, ErrorMessage = "I broke a logic" };
        }
    }
}
