using System;

namespace FileSyncer
{
    class FTPFolderPair : ICSVFormat, IListViewRow
    {
        #region Fields
        int? id;
        string friendlyName;
        string sourceIP;
        int port;
        bool passive;       // connection Type
        string sharedFolder;
        string userName;
        string passWord;
        string destinationFolder;
        DateTime added;
        DateTime startSync;
        DateTime stopSync;
        bool deleteSourceFiles;
        bool enabled;
        #endregion

        #region Properties
        public int? Id
        {
            get => id;
            private set
            {
                if (id == null)
                {
                    id = value;
                }
                else
                {
                    throw new InvalidOperationException("the DataBase Engine sets the ID");
                }
            }
        }
        public string FriendlyName {
            get => friendlyName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    friendlyName = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }       
        public string SourceIP { 
            get => sourceIP;
            set
            {
                if (Validator.IP(value))
                {
                    sourceIP = value;
                }
                else
                {
                    throw new ArgumentException("Invalid IP set for FTP server");
                }
            }  
        }
        public int Port { 
            get => port;
            set
            {
                if (1 <= value && value <= 65565)
                {
                    port = value;
                }
                else
                {
                    port = 21;
                }
            } 
        }
        public bool Passive { get => passive; set => passive = value; }
        public string SharedFolder
        {
            get => sharedFolder;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    sharedFolder = value;
                }
            }
        }
        public string UserName
        {
            get => userName;
            internal set
            {
                if (Validator.Username(value))
                {
                    userName = value;
                }
                else
                {
                    throw new InvalidOperationException("Invalid username");
                }
            }
        }
        public string PassWord
        {
            get => passWord;
            internal set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    passWord = value;
                }
            }
        }
        public string DestinationFolder
        {
            get => destinationFolder;
            set
            {
                if (Validator.Folder(value))
                {
                    destinationFolder = value;
                }
                else
                {
                    throw new ArgumentException("Destination Folder does not exist");
                }
            }
        }
        public DateTime Added { get => added; set => added = value; }
        public DateTime StartSync { get => startSync; set => startSync = value; }
        public DateTime StopSync { get => stopSync; set => stopSync = value; }        
        public bool DeleteSourceFiles { get => deleteSourceFiles; set => deleteSourceFiles = value; }
        public bool Enabled { get => enabled; set => enabled = value; }
        #endregion

        #region Constructors
        public FTPFolderPair()
        {
            // Dapper needs this
        }
        // this constructor is for the DynamicDataStore class, when reading all FTPFolderPair into its internal list from the DataBase
        // the added property is filled with the original creation time
        public FTPFolderPair(string friendlyName, string sourceIP, int port, bool passive, string sharedFolder, string userName, string passWord, string destinationFolder, DateTime added, DateTime startSync, DateTime stopSync, bool deleteSourceFiles, bool enabled)
        {
            Id = id;
            FriendlyName = friendlyName;
            SourceIP = sourceIP;
            Port = port;
            Passive = passive;
            SharedFolder = sharedFolder;
            UserName = userName;
            PassWord = passWord;
            DestinationFolder = destinationFolder;
            Added = added;
            StartSync = startSync;
            StopSync = stopSync;
            DeleteSourceFiles = deleteSourceFiles;
            Enabled = enabled;
        }
                
        // Dapper uses this when filling up the DynamicDataStore from DB
        public FTPFolderPair(int? id, string friendlyName, string sourceip, int port, bool passive, string sharedFolder, string username, string password, string destinationFolder, DateTime added, DateTime startSync, DateTime stopSync, bool deleteSourceFiles, bool enabled) :this(friendlyName, sourceip, port, passive, sharedFolder, username, password, destinationFolder, added, startSync, stopSync, deleteSourceFiles, enabled)
        {
            Id = id;           
        }
        #endregion

        #region Methods, Functions
        public override string ToString()
        {
            string status = enabled ? "enabled" : "disabled";
            string p = passive ? "passive FTP" : "active FTP";
            return $"{friendlyName}\t{sourceIP}\t{port}\t{p}\t{sharedFolder}\t{destinationFolder}\t{StartSync}\t{StopSync}\t{status}";
        }       
        #endregion

        #region Interface Implementations
        public string CSVFormat()
        {
            return $"{id};{friendlyName};{sourceIP};{port};{passive};{sharedFolder};{destinationFolder};{added};{startSync};{stopSync};{enabled};{deleteSourceFiles}";
        }
        public string[] ListViewRow()
        {
            string[] array = {id.ToString(), friendlyName, sourceIP.ToString(), port.ToString(), sharedFolder, destinationFolder, added.ToString(), startSync.ToString(), stopSync.ToString(), deleteSourceFiles.ToString(), enabled.ToString() };
            return array;
        }
        #endregion
    }
}
