using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Dapper;
using System.Linq;
using FileSyncer.Control;
using FileSyncer.Entity;

namespace FileSyncer
{
    static class DBHandler
    {
        #region Fields
        static SqlConnection connection;
        static SqlCommand command;
        static bool connected;
        #endregion

        #region Properties
        public static bool Connected { get => connected; }


        #endregion

        #region Methods, Functions

        #region ConnectionString
        static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["FileSyncerDB"].ConnectionString;
        }
        internal static void Connect()
        {
            //Logger.AddLog("Connecting to ServiceBased Local DB");       
            try
            {
                connection = new SqlConnection(LoadConnectionString());
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                connected = true;
                //Logger.AddLog("DB Connected");
            }
            catch (Exception ex)
            {
                ApplicationLogger.AddLog($"Could not connect to to the DataBase {ex}");
                throw new DBHandlerExeption("Could not connect to to the DataBase ", ex);
            }
        }
        #endregion

        #region SMB FolderPairs CRUD
        internal static void InsertSMBFolderPair(SMBFolderPair _new)
        {
            /* Dapper doesnt need this
            if (connection.State != ConnectionState.Open)
            {
                Connect();
            }
            */
            try
            {
                using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
                {
                    string sql = "INSERT INTO SMBFolderPairs(FriendlyName,SourceFolder,DestinationFolder,Added,StartSync,StopSync,DeleteSourceFiles,Enabled) " +
                                                   "VALUES (@FriendlyName,@SourceFolder,@DestinationFolder,@Added,@StartSync,@StopSync,@DeleteSourceFiles,@Enabled)";
                    connection.Execute(sql, _new);
                }
            }
            catch (Exception ex)
            {
                var message = $"Could not insert SMBFolderPair into the DataBase {ex}";
                ApplicationLogger.AddLog(message);
                throw new DBHandlerExeption(message, ex);
            }
        }
        internal static void UpdateSMBFolderPair(SMBFolderPair _mod)
        {
            if (connection.State != ConnectionState.Open)
            {
                Connect();
            }
            try
            {
                using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
                {
                    string sql = "UPDATE [SMBFolderPairs] SET [FriendlyName] = @FriendlyName, [SourceFolder] = @SourceFolder, [DestinationFolder] = @DestinationFolder, [Added] = @Added, [StartSync] = @StartSync, [StopSync] = @StopSync, [Enabled] = @Enabled, [DeleteSourceFiles] = @DeleteSourceFiles";
                    connection.Execute(sql, _mod);
                }
            }
            catch (Exception ex)
            {
                var message = $"Could not modify Folderpair {ex}";
                throw new DBHandlerExeption(message, ex);
            }
        }
        internal static void DeleteSMBFolderPair(SMBFolderPair del)
        {
            if (connection.State != ConnectionState.Open)
            {
                Connect();
            }
            try
            {
                using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
                {
                    string sql = "DELETE FROM[SMBFolderPairs] WHERE[Id] = @Id";
                    connection.Execute(sql, del);
                }

            }
            catch (Exception ex)
            {
                var message = $"Could not delete FolderPair {ex}";

                ApplicationLogger.AddLog(message);

                throw new DBHandlerExeption(message, ex);
            }
        }
        internal static List<SMBFolderPair> LoadSMBFolderPairs()
        {
            using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
            {
                var sql = "SELECT * FROM [SMBFolderPairs]";
                var folderPairs = connection.Query<SMBFolderPair>(sql).ToList();
                return folderPairs;

                /*
                var sql = "SELECT [Id],[FriendlyName],[SourceFolder],[DestinationFolder],[Added],[StartSync],[StopSync],[DeleteSourceFiles],[Enabled] FROM [dbo].[SMBFolderPairs]";
                var folderPairs = connection.Query<SMBFolderPair>(sql).ToList();
                return folderPairs;
                */
            }
        }
        #endregion

        #region FTP FolderPair CRUD

        internal static void InsertFTPFolderPair(FTPFolderPair _new)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
                {
                    string sql = "INSERT INTO FTPFolderPairs(FriendlyName,SourceIP,Port,Passive,SharedFolder,UserName,PassWord,DestinationFolder,Added,StartSync,StopSync,DeleteSourceFiles,Enabled) VALUES" +
                                                          "(@FriendlyName,@SourceIP,@Port,@Passive,@SharedFolder,@UserName,@PassWord,@DestinationFolder,@Added,@StartSync,@StopSync,@DeleteSourceFiles,@Enabled)";
                    connection.Execute(sql, _new);
                }
            }
            catch (Exception ex)
            {
                var message = $"Could not insert FTPFolderPair into the DataBase {ex}";
                ApplicationLogger.AddLog(message);
                throw new DBHandlerExeption(message, ex);
            }
        }
        internal static void UpdateFTPFolderPair(FTPFolderPair _mod)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
                {
                    string sql = "UPDATE [FTPFolderPairs] SET [FriendlyName] = @FriendlyName, [SourceIP] = @SourceIP, [Port] = @Port, [Passive] = @Passive, [SharedFolder] = @SharedFolder, [UserName] = @UserName, [PassWord] = @PassWord, [DestinationFolder] = @DestinationFolder, [Added] = @Added, [StartSync] = @StartSync, [StopSync] = @StopSync, [DeleteSourceFiles] = @DeleteSourceFiles, [Enabled] = @Enabled";
                    connection.Execute(sql, _mod);
                }
            }
            catch (Exception ex)
            {
                var message = $"Could not modify FTP Folderpair {ex}";
                ApplicationLogger.AddLog(message);
                throw new DBHandlerExeption(message, ex);
            }
        }
        internal static void DeleteFTPFolderPair(FTPFolderPair del)
        {
            /* Dapper opens the connection
            if (connection.State != ConnectionState.Open)
            {
                Connect();
            }
            */
            try
            {
                using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
                {
                    string sql = "DELETE FROM[FTPFolderPairs] WHERE[Id] = @Id";
                    connection.Execute(sql, del);
                }
            }
            catch (Exception ex)
            {
                var message = $"Could not delete FTP FolderPair {ex}";
                ApplicationLogger.AddLog(message);
                
                throw new DBHandlerExeption(message, ex);
            }
        }

        internal static List<FTPFolderPair> LoadFTPFolderPairs()
        {
            using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
            {
                var folderPairs = connection.Query<FTPFolderPair>("SELECT * FROM [FTPFolderPairs]").ToList();
                foreach (var item in folderPairs)
                {
                    var e = item.PassWord;
                    item.PassWord = Xor.Decrypt(e);
                }
                return folderPairs;
            }
        }
        #endregion

        #region SFTP Folder Pair CRUD
        internal static void InsertSFTPFolderPair(SFTPFolderPair _new)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
                {
                    string sql = "INSERT INTO SFTPFolderPairs(FriendlyName,IP, Port, UserName, PassWord, SharedFolder, DestinationFolder,Added,StartSync,StopSync,DeleteSourceFiles,Enabled) " +
                                                   "VALUES (@FriendlyName,@IP, @Port, @UserName, @PassWord, @SharedFolder,@DestinationFolder,@Added,@StartSync,@StopSync,@DeleteSourceFiles,@Enabled)";
                    connection.Execute(sql, _new);
                }
            }
            catch (Exception ex)
            {
                var message = $"Could not insert SFTPFolderPair into the DataBase {ex}";
                ApplicationLogger.AddLog(message);
                throw new DBHandlerExeption(message, ex);
            }
        }
        internal static void UpdateSFTPFolderPair(SFTPFolderPair _mod)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
                {
                    string sql = "UPDATE [SFTPFolderPairs] SET [FriendlyName] = @FriendlyName, [IP] = @IP, [Port] = @Port, [UserName] = @UserName, [PassWord] = @PassWord, [SharedFolder] = @SharedFolder, [DestinationFolder] = @DestinationFolder, [Added] = @Added, [StartSync] = @StartSync, [StopSync] = @StopSync, [DeleteSourceFiles] = @DeleteSourceFiles, [Enabled] = @Enabled";
                    connection.Execute(sql, _mod);
                }
            }
            catch (Exception ex)
            {
                var message = $"Could not modify SFTP Folderpair {ex}";
                ApplicationLogger.AddLog(message);
                throw new DBHandlerExeption(message, ex);
            }
        }
        internal static void DeleteSFTPFolderPair(SFTPFolderPair del)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
                {
                    string sql = "DELETE FROM[SFTPFolderPairs] WHERE[Id] = @Id";
                    connection.Execute(sql, del);
                }
            }
            catch (Exception ex)
            {
                var message = $"Could not delete SFTP FolderPair {ex}";
                ApplicationLogger.AddLog(message);

                throw new DBHandlerExeption(message, ex);
            }
        }
        internal static List<SFTPFolderPair> LoadSFTPFolderPairs()
        {
            using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
            {
                var folderPairs = connection.Query<SFTPFolderPair>("SELECT * FROM [SFTPFolderPairs]").ToList();
                foreach (var item in folderPairs)
                {
                    var e = item.PassWord;
                    item.PassWord = Xor.Decrypt(e);
                }
                return folderPairs;
            }
        }
        #endregion

        #region User CRUD
        internal static void AddUser(User _new)
        {
            using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
            {
                string sql = "INSERT INTO [Users]([UserName],[PassWord],[UserLevel]) VALUES (@UserName, @PassWord,@UserLevel)";
                connection.Execute(sql, _new);
            }
        }
        internal static void UpdateUser(User mod)
        {
            string sql = "UPDATE [Users] SET [UserName] = @UserName, [PassWord] = @PassWord, [UserLevel] = @UserLevel WHERE [Id] = @Id";
            connection.Execute(sql, mod);
        }
        internal static void DeleteUser(User _del)
        {
            try
            {  
                string sql = "DELETE FROM [Users] WHERE [Id] = @Id";
                connection.Execute(sql, _del);
            }
            catch (Exception ex)
            {
                var message = $"Could not delete user {ex}";
                if (ApplicationLogger.Logging_enabled)
                {
                    ApplicationLogger.AddLog(message);
                }
                throw new DBHandlerExeption(message, ex);
            }
        }
        public static void RemoveUser(User _del)
        {
            using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
            {
                var sql = "DELETE FROM [Users] WHERE [UserName] = @Username";
                connection.Execute(sql, param: new { UserName = _del.UserName });
            }
        }
        internal static List<User> LoadUsers()
        {
            using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
            {
                var users = connection.Query<User>("SELECT * FROM [Users]").ToList();
                return users;
            }
        }        
        #endregion

        #region SyslogServer

        internal static SyslogServer LoadSyslogServer()
        {
            using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
            {
                string sql = @"SELECT TOP 1 * FROM [dbo].[SyslogServer];";
                var server = connection.QuerySingle<SyslogServer>(sql);
                return server;
            }
        }
        internal static void InsertSyslogServer(SyslogServer server)
        {
            using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
            {
                connection.Execute("TRUNCATE TABLE SyslogServer;");
                string sql = "INSERT INTO [SyslogServer](Ip, Port, Enabled) VALUES (@Ip, @Port, @Enabled);";
                connection.Execute(sql, server);
            }
        }
        // There is only 1 Sylog server, thus the Insert always truncates the DB
        /*
        internal static void UpdateSyslogServer(SyslogServer server)
        {
            using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
            {
                string sql = "UPDATE [dbo].[Syslogserver] SET Ip=@Ip, Port=@Port WHERE Ip=@Ip;";
            }
        }
        */

        internal static void Disconnect()
        {
            connection.Close();
        }

        #endregion

        #endregion
    }
}
