using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L1HW
{
    internal class Starter
    {
        /// <summary>
        /// Method that runs a program by creating a logger instance and generates logs randomly by calling a random method.
        /// </summary>
        public static void Run()
        {
            Actions actions = new Actions();
            var logger = Logger.Instance;
            for (int i = 0; i < 100; i++)
            {
                Result res = new Result();
                Random random = new Random();
                int method = random.Next(0, 3);
                switch (method)
                {
                    case 0:
                        res = actions.FirstMethod();
                        break;
                    case 1:
                        res = actions.SecondMethod();
                        break;
                    case 2:
                        res = actions.ThirdMethod();
                        break;
                }

                if (!res.Status)
                {
                    string msg = $"Action failed by a reason: {res.ErrorMessage}";
                    DateTime dateTime = DateTime.Now;
                    logger.Logs.Add($"{{{dateTime}}}: {{Error}}: {{{msg}}}");
                }
            }

            logger.WriteInFile();
        }
    }
}
