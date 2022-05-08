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

        public List<string> Logs { get; set; } = new List<string>();

        public void WriteInFile()
        {
            string res = string.Empty;
            for (int i = 0; i < Logs.Count; i++)
            {
                res += Logs[i] + "\n";
            }

            Console.WriteLine(res);
            File.WriteAllText("log.txt", res);
        }
    }
}
