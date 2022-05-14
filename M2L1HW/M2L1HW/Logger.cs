using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L1HW
{
    /// <summary>
    /// Singletone pattern is realized.
    /// </summary>
    public sealed class Logger
    {
        private static Logger instance = null;

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        public string[] Logs { get; set; } = new string[100];

        /// <summary>
        /// Method that writes all the logs in file and console.
        /// </summary>
        public void WriteInFile()
        {
            string res = string.Empty;
            for (int i = 0; i < Logs.Length; i++)
            {
                res += Logs[i] + "\n";
            }

            Console.WriteLine(res);
            File.WriteAllText("log.txt", res);
        }

        public static Result CreatingObjects(string type, string name)
        {
            DateTime dateTime = DateTime.Now;
            var logger = Logger.Instance;
            logger.Logs[Starter.CurrIndex] = $"{{{dateTime}}}: {{{type}}}: {{Start Method: {name}}}";
            if (type == "Error")
            {
                return new Result { Status = false };
            }

            return new Result { Status = true };
        }
    }
}
