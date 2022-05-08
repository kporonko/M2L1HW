using System;

namespace M2L1HW
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var logger = Logger.Instance;
            var logger2 = Logger.Instance;
            Starter.Run();
            Console.Read();
        }
    }
}
