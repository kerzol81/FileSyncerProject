using System;


namespace FileSyncer.Control
{
    class SFTPFolderPair : ICSVFormat, IListViewRow
    {
        #region Fields
        int? id;
        string friendlyName;
        string ip;
        int port;
        string userName;
        string passWord;
        string sharedFolder;
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
                    var message = $"{friendlyName} - the DataBase Engine sets the Rsync Folder Pairs's ID";
                    //Logger.AddLog(message);
                    throw new ArgumentException(message);
                }
            }
        }
        public string FriendlyName
        {
            get => friendlyName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    friendlyName = value;
                }
                else
                {
                    var message = $"{friendlyName} - Name cannot be empty";
                    //Logger.AddLog(message);
                    throw new ArgumentException(message);
                }
            }
        }
        public string IP
        {
            get => ip;
            set
            {
                if (Validator.IP(value))
                {
                    ip = value;
                }
                else
                {
                    var message = $"{friendlyName} - Invalid IP set for Rsync server";
                    //Logger.AddLog(message);
                    throw new ArgumentException(message);
                }
            }
        }
        public int Port
        {
            get => port;
            set
            {
                if (1 <= value && value <= 65565)
                {
                    port = value;
                }
                else
                {
                    port = 22;             // default
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
                    var message = $"{friendlyName} - Invalid username";
                    //Logger.AddLog(message);
                    throw new InvalidOperationException(message);
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
                    //passWord = Helper.sha256_hash(value);
                    passWord = value;
                }
            }
        }

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
                    var message = $"{friendlyName} - Destination Folder does not exist";
                    //Logger.AddLog(message);
                    throw new ArgumentException(message);
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
        public SFTPFolderPair()
        {
            // Exporter.cs and Dapper needs a parameterless constructor
        }
        public SFTPFolderPair(string friendlyName, string iP, int port, string userName, string passWord, string sharedFolder, string destinationFolder, DateTime added, DateTime startSync, DateTime stopSync, bool deleteSourceFiles, bool enabled)
        {
          
            FriendlyName = friendlyName;
            IP = iP;
            Port = port;
            UserName = userName;
            PassWord = passWord;
            SharedFolder = sharedFolder;
            DestinationFolder = destinationFolder;
            Added = added;
            StartSync = startSync;
            StopSync = stopSync;
            DeleteSourceFiles = deleteSourceFiles;
            Enabled = enabled;
        }

        public SFTPFolderPair(int? id, string friendlyName, string iP, int port, string userName, string passWord, string sharedFolder, string destinationFolder, DateTime added, DateTime startSync, DateTime stopSync, bool deleteSourceFiles, bool enabled):this(friendlyName, iP, port, userName, passWord, sharedFolder, destinationFolder, added, startSync, stopSync, deleteSourceFiles, enabled)
        {
            Id = id;   
        }

        #endregion

        #region Interface Implementations
        public string CSVFormat()
        {
            //throw new NotImplementedException();
            return $"{id};{friendlyName};{ip};{port};{sharedFolder};{destinationFolder};{added};{startSync};{stopSync};{enabled};{deleteSourceFiles}";
        }

        public string[] ListViewRow()
        {
            //throw new NotImplementedException();
            string[] array = { id.ToString(), friendlyName, ip.ToString(), port.ToString(), sharedFolder, destinationFolder, added.ToString(), startSync.ToString(), stopSync.ToString(), deleteSourceFiles.ToString(), enabled.ToString() };
            return array;
        }
        #endregion
    }
}
