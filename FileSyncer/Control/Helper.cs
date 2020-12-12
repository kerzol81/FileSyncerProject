using System;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FileSyncer.Control
{
    static class Helper
    {
    #region SyslogServer Related
        private static SyslogServer server;
        public static bool isSyslogEnabled()
        {
            server = DBHandler.LoadSyslogServer();
            return server.Enabled;
        }
        public static bool isSyslogOnline()
        {
            PingReply pingReply;
            using (var ping = new Ping())
            {
                pingReply = ping.Send(server.Ip);
            }
            if (pingReply.Status == IPStatus.Success)
            {
                return true;
            }
            return false;
        }
        #region ListView Related
        // https://stackoverflow.com/questions/1257500/c-sharp-listview-column-width-auto
        public static void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }

        // https://stackoverflow.com/questions/4879197/using-reflection-read-properties-of-an-object-containing-array-of-another-object
        public static void GetObjectProperties(object obj)
        {
            foreach (PropertyInfo pinfo in obj.GetType().GetProperties())
            {
                var getMethod = pinfo.GetGetMethod();
                if (getMethod.ReturnType.IsArray)
                {
                    var arrayObject = getMethod.Invoke(obj, null);
                    foreach (object element in (Array)arrayObject)
                    {
                        foreach (PropertyInfo arrayObjPinfo in element.GetType().GetProperties())
                        {
                            Console.WriteLine(arrayObjPinfo.Name + ":" + arrayObjPinfo.GetGetMethod().Invoke(element, null).ToString());
                        }
                    }
                }
            }
        }
        #endregion

        #region Password related stuff

        // https://stackoverflow.com/questions/16999361/obtain-sha-256-string-of-a-string
        public static string sha256_hash(string password)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(password));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        #endregion  
    }
    #endregion


}
