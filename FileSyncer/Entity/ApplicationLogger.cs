using System;
using System.Collections.Generic;
using SyslogLogging;
using FileSyncer.Control;

namespace FileSyncer.Entity
{
    static class ApplicationLogger
    {
        static List<string> logs;
        private static SyslogServer syslogServer;
        private static LoggingModule lm;
        private static readonly string appname = "FileSyncer";
        public static List<string> Logs { get => logs; /*set => logs = value; */}
        public static bool Logging_enabled { get; set; }

        static ApplicationLogger()
        {
            Logging_enabled = true;
            logs = new List<string>();
            syslogServer = DBHandler.LoadSyslogServer();
            lm = new LoggingModule(syslogServer.Ip, syslogServer.Port, false, Severity.Info, true, true, true, true, false, false);
        }

        public static void AddLog(string message)
        {
            if (!string.IsNullOrWhiteSpace(message) && Logging_enabled)
            {
                logs.Add($"{DateTime.Now}\t{message}");
            }
            try
            {
                SendLogToSyslogServer(appname + ":" + message);
            }
            catch (Exception ex)
            {
                //throw;
                logs.Add($"Syslog sending error: {ex}");
            }             
        }

        public static void SendLogToSyslogServer(string message)
        {
            if (Helper.isSyslogEnabled())
            {
                lm.Info(message);
            }
        }
    }
}
