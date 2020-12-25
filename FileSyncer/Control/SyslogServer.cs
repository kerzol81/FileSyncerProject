
namespace FileSyncer.Control
{
    class SyslogServer : ICSVFormat
    {
        #region Fields
        string ip;
        int port;

        public string Ip { 
            get => ip;
            set
            {
                if (Validator.IP(value))
                {
                    ip = value;
                }
            }  
        }
        public int Port { get => port; set => port = value; }
        public bool Enabled { get; set; }
        #endregion

        // Dapper's QuerySingle method cannot create an object with Properties
        /*
        #region Properties
        public string Ip { 
            get => ip; 
            set
            {
                if (Validator.IP(value))
                {
                    value = ip;
                }
                else
                {
                    throw new ArgumentException("Invalid IP address");
                }
            } 
        }
        public int Port { 
            get => port;
            set
            {
                if (1 <= value && value <= 65535)
                {
                    port = value;
                }
                else
                {
                    port = 514;
                }
            } 
        }
        #endregion
        */
        #region Constructor

        public SyslogServer(string ip, int port, bool enabled)
        {
            Ip = ip;
            Port = port;
            Enabled = enabled;
        }
        #endregion

        #region Functions, Methods, Interface Implementation

        public override string ToString()
        {
            return $"{Ip}\t{Port}";
        }

        public string CSVFormat()
        {
            return $"{Ip};{Port}";
        }        
        #endregion
    }
    
}
