using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace FileSyncer
{
    public static class Validator
    {
        internal static bool Folder(string path)
        {
            if (Directory.Exists(path))
            {
                return true;
            }
            return false;
        }
        internal static bool Username(string username)
        {
            if (username.Length >= 3 && username != "root" && username != "admin")
            {
                return true;
            }
            return false;
        }
        internal static bool Password(string password)
        {
            if (password.Length >= 8 && password.ToLower() != password && password.ToUpper() != password)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (password.Contains(i.ToString()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        internal static bool IP(string ip)
        {
            if (IPAddress.TryParse(ip, out IPAddress address))
            {
                return true;
            }
            return false;
            
        }
        internal static bool Port(int port)
        {
            if (0 < port && port <65565)
            {
                return true;
            }
            return false;
        }
    }
}