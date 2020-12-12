using FileSyncer.Control;
using System.IO;

namespace FileSyncer.Entity
{
    static class LogWriter
    {
        public static bool WriteLogs(string path)
        {
            if(ApplicationLogger.Logs.Count > 0)
            {
                StreamWriter s = new StreamWriter(path);
                foreach (var log in ApplicationLogger.Logs)
                {
                    s.WriteLine(log);
                }
                s.Close();
                return true;
            }
            return false;
            
        }
    }
}
