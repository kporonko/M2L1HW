using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L1HW
{
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

        public static string Log { get; set; }

        public static void WriteInFile()
        {
            Console.WriteLine(Log);
            File.WriteAllText("log.txt", Log);
        }
    }
}
