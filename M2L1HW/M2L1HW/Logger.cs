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

        public static List<string> Logs { get; set; }

        public static void WriteInFile()
        {
            File.WriteAllText("log.txt", Logs[Logs.Count - 1]);
            Logs.RemoveAt(Logs.Count - 1);
        }
    }
}
