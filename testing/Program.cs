using System;
using System.Diagnostics;
using SyslogLogging;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggingModule l = new LoggingModule("192.168.50.10", 514);

            l.Debug("debug log from Filesyncer");
            l.Emergency("emergency log from Filesyncer");

            Debug.Print("Done");
        }
    }
}
