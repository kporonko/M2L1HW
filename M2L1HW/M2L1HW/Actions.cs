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
            var logger = Logger.Instance;
            logger.Logs.Add($"{{{dateTime}}}: {{Info}}: {{Start Method: {MethodBase.GetCurrentMethod().Name}}}");
            return new Result { Status = true };
        }

        public Result SecondMethod()
        {
            DateTime dateTime = DateTime.Now;
            var logger = Logger.Instance;
            logger.Logs.Add($"{{{dateTime}}}: {{Warning}}: {{Skipped logic in Method: {MethodBase.GetCurrentMethod().Name}}}");
            return new Result { Status = true };
        }

        public Result ThirdMethod()
        {
            return new Result { Status = false, ErrorMessage = "I broke a logic" };
        }
    }
}
