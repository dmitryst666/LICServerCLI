using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LICServerCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            int maxConn = 10;
            logger.Trace("--------------------------------------------------------------  New Instance started...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("New instance is starting up....");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
