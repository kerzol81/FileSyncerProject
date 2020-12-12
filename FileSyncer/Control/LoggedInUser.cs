using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSyncer.Control
{
    static class LoggedInUser
    {
        static User user;
        public static User User { get => user; set => user = value; }
    }
}
