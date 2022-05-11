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

        /// <summary>
        /// Gets or sets (idn why the ruleset want me to write that). List of all the logs generated in the program.
        /// </summary>
#pragma warning disable SA1609 // Property documentation should have value
        public List<string> Logs { get; set; } = new List<string>();
#pragma warning restore SA1609 // Property documentation should have value

        /// <summary>
        /// Method that writes all the logs in file and console.
        /// </summary>
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
