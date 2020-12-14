using System;
using System.IO;
using System.Threading;
using FileSyncer.Control;
using FileSyncer.Entity;

namespace FileSyncer
{
    class SMBFolderPair : ICSVFormat, IListViewRow
    {
        #region Fields
        int? id;
        string friendlyName;
        string sourceFolder;
        string destinationFolder;
        DateTime added;
        DateTime startSync;
        DateTime stopSync;
        bool deleteSourceFiles;
        bool enabled;
        FileSystemWatcher watchdog;
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
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }
        public string SourceFolder
        {
            get => sourceFolder;
            set => sourceFolder = value;
            /* No need to validation since the source will be picket by a FolderBrowserDialog in the GUI
            set {
                if (Validator.Folder(value))
                {
                    sourceFolder = value;
                }
                else
                {
                    throw new ArgumentException("Source Folder does not exist");
                }
            }
            */
        }
        public string DestinationFolder
        {
            get => destinationFolder;
            set => destinationFolder = value;
            /* No need to validation since the destination will be picket by a FolderBrowserDialog in the GUI
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
            */
        }
        public DateTime Added { get => added; private set => added = value; }
        public DateTime StartSync { get => startSync; set => startSync = value; }
        public DateTime StopSync { get => stopSync; set => stopSync = value; }
        public bool DeleteSourceFiles { get => deleteSourceFiles; set => deleteSourceFiles = value; }
        public FileSystemWatcher Watchdog { get => watchdog; /*set => watchdog = value;*/ }
        public bool Enabled { get => enabled; set => enabled = value; }
        #endregion

        #region Constructors
        public SMBFolderPair()
        {
            // Dapper needs a parameterless constructor
        }
        // DB read to Dynamic Data Store
        public SMBFolderPair(int? id, string friendlyName, string sourceFolder, string destinationFolder, DateTime added, DateTime startSync, DateTime stopSync, bool deleteSourceFiles, bool enabled)
        {
            Id = id;
            FriendlyName = friendlyName;
            SourceFolder = sourceFolder;
            DestinationFolder = destinationFolder;
            Added = added;
            StartSync = startSync;
            StopSync = stopSync;
            DeleteSourceFiles = deleteSourceFiles;
            Enabled = enabled;
            watchdog = new FileSystemWatcher(sourceFolder)
            {
                EnableRaisingEvents = true,
                IncludeSubdirectories = true
            };
            watchdog.Created += FileCreatedInSourceFolder;
        }

        public SMBFolderPair(string friendlyName, string sourceFolder, string destinationFolder, DateTime added, DateTime startSync, DateTime stopSync, bool deleteSourceFiles = false, bool enabled = true)
        {
            FriendlyName = friendlyName;
            SourceFolder = sourceFolder;
            DestinationFolder = destinationFolder;
            Added = added;
            StartSync = startSync;
            StopSync = stopSync;
            DeleteSourceFiles = deleteSourceFiles;
            Enabled = enabled;

            watchdog = new FileSystemWatcher(sourceFolder)
            {
                EnableRaisingEvents = true,
                IncludeSubdirectories = true
            };
            watchdog.Created += FileCreatedInSourceFolder;
        }

        #region Events
        private void FileCreatedInSourceFolder(object sender, FileSystemEventArgs e)
        {
            ApplicationLogger.AddLog($"{e.Name} created in {friendlyName}");
            Thread.Sleep(200);
            //bool validTime = startSync < DateTime.Now && DateTime.Now < stopSync;
            bool inBetweenSyncBoundary = startSync < DateTime.Now && stopSync > DateTime.Now;
            if (inBetweenSyncBoundary && enabled && deleteSourceFiles is true)
            {
                //File.Move(e.FullPath, Path.Combine(destinationFolder, e.Name));
                // Sophisticated way than simple copy - if network loss
                bool differentFiles = true;
                while (differentFiles)
                {
                    File.Copy(e.FullPath, Path.Combine(destinationFolder, e.Name), true); //overwrite
                    if (CompareFiles.Compare(e.FullPath, Path.Combine(destinationFolder, e.Name)))
                    {
                        differentFiles = false;
                        File.Delete(e.FullPath);
                    }
                    else
                    {
                        ApplicationLogger.AddLog("Error during syncronistaion, retry...");
                        Thread.Sleep(1000);
                    }
                }
                ApplicationLogger.AddLog($"{friendlyName} synced");
                //ApplicationLogger.AddLog($"{e.Name} Moved in {friendlyName}");
            }
            else if (inBetweenSyncBoundary && enabled && deleteSourceFiles == false)
            {
                File.Copy(e.FullPath, Path.Combine(destinationFolder, e.Name));
                ApplicationLogger.AddLog($"{friendlyName} synced");
                //ApplicationLogger.AddLog($"File Copied {friendlyName}");
            }
            else
            {
                ApplicationLogger.AddLog($"Out of Time: {e.Name} was created in {friendlyName} {sourceFolder}");
            }
        }
        #endregion


        #endregion

        #region Methods, Functions
        public override string ToString()
        {
            string status = enabled ? "enabled" : "disabled";
            return $"{friendlyName} - {sourceFolder} - {destinationFolder} - {StartSync} - {StopSync} - {status}";
        }
        public string CSVFormat()
        {
            return $"{id};{friendlyName};{sourceFolder};{destinationFolder};{added};{startSync};{stopSync};{deleteSourceFiles};{enabled}";
        }
        public string[] ListViewRow()
        {
            string[] array = { id.ToString(), friendlyName, sourceFolder, destinationFolder, added.ToString(), startSync.ToString(), stopSync.ToString(), deleteSourceFiles.ToString(), enabled.ToString() };
            return array;
        }
        #endregion
    }
}
